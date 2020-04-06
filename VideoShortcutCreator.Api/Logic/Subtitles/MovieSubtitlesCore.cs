using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using VideoShortcutCreator.Api.Logic;

namespace Test.Logic.Subtitles
{
    public class MovieSubtitlesCore
    {
        private readonly HttpClient _httpClient;
        public MovieSubtitlesCore()
        {
        }

        public async Task DownloadSubtitles(string movieTitle, SubtitleLanguage lang, string destination)
        {
            var subtitles = GetSubtitles(movieTitle, lang);
            DownloadSubtitlesZipAndExtract(subtitles, destination);
        }

        public async Task<IList<string>> DownloadSubtitles(IList<FileInfo> movies, SubtitleLanguage lang, string destination = "")
        {
            IList<string> nonProcessedMovies = new List<string>();

            await Task.Run(() =>
            {
                Parallel.ForEach<FileInfo>(movies, (movie) =>
                {
                    try
                    {
                        var movieTitle = Path.GetFileName(movie.FullName);
                        var subtitles = GetSubtitles(movieTitle, lang);
                        if (!subtitles.Any())
                        {
                            nonProcessedMovies.Add(movie.Name);
                        }

                        DownloadSubtitlesZipAndExtract(subtitles, movie.DirectoryName);

                    }
                    catch (Exception ex)
                    {
                    }
                });
            });

            return nonProcessedMovies;
        }

        private IList<MovieSubtitle> GetSubtitles(string movieTitle, SubtitleLanguage lang)
        {
            IList<MovieSubtitle> subtitles = new List<MovieSubtitle>();
            try
            {
                if (string.IsNullOrEmpty(movieTitle))
                {
                    return subtitles;
                }

                var openSubtitlesUrl = $"https://rest.opensubtitles.org/search/query-{movieTitle}/sublanguageid-{lang}";
                WebRequest requestSubtitles = WebRequest.Create(openSubtitlesUrl);
                requestSubtitles.Headers.Add("X-User-Agent", "TemporaryUserAgent");
                HttpWebResponse response = (HttpWebResponse)requestSubtitles.GetResponse();

                // Get the stream associated with the response.
                Stream receiveStream = response.GetResponseStream();

                // Pipes the stream to a higher level stream reader with the required encoding format. 
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                //Console.WriteLine(JValue.Parse(readStream.ReadToEnd()).ToString(Formatting.Indented));
                var streamResponseString = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
                subtitles = JsonConvert.DeserializeObject<IList<MovieSubtitle>>(streamResponseString);

                return subtitles;
            }
            catch (Exception)
            {
                return subtitles;
            }
        }

        private void DownloadSubtitlesZipAndExtract(IList<MovieSubtitle> subtitles, string destination)
        {
            if (subtitles.Any() && !string.IsNullOrEmpty(destination))
            {
                var zipPath = Path.Combine(new string[] { destination, $"{subtitles.First().MovieReleaseName.Trim()}.zip" });

                WebRequest objRequest = WebRequest.Create(subtitles.First().ZipDownloadLink);
                var objResponse = objRequest.GetResponse();
                byte[] buffer = new byte[32768];

                bool extracted = false;
                using (Stream input = objResponse.GetResponseStream())
                {
                    if (!File.Exists(zipPath))
                    {
                        try
                        {
                            using (FileStream output = new FileStream(zipPath, FileMode.CreateNew))
                            {
                                int bytesRead;

                                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    output.Write(buffer, 0, bytesRead);
                                }
                            }

                            ZipFile.ExtractToDirectory(zipPath, Path.GetDirectoryName(zipPath));
                            extracted = true;
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }

                if (extracted)
                {
                    var srt = FileExtractor.GetAllContent(Path.GetDirectoryName(zipPath)).GetSubtitles().FirstOrDefault();
                    var movie = FileExtractor.GetAllContent(Path.GetDirectoryName(zipPath)).GetMovies().FirstOrDefault();

                    if (srt != null && !movie.IdenticalNames(srt))
                    {
                        srt.Rename(Path.ChangeExtension(movie.FullName, Path.GetExtension(srt.FullName)));
                    }

                    FileExtractor
                        .GetAllContent(Path.GetDirectoryName(zipPath))
                        .TakeWhile(wr => !wr.IsMovieFile() && !wr.IsSubtitleFile())
                        .ToList()
                        .ForEach(f => File.Delete(f.FullName));
                }
            }
        }
    }
}
