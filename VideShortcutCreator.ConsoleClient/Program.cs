using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenScraping;
using OpenScraping.Config;
using ScrapySharp.Extensions;
using ScrapySharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Web;
using Test.Logic;
using Test.Logic.Subtitles;
using VideoShortcutCreator.Api.Logic;

namespace VideShortcutCreator.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Shortcuts
            // Test directory
            //string rootDirectory = @"D:\movies\Shortcuts testing";

            //var folderInfo = new DirectoryInfo(rootDirectory);

            //CreateShortcuts(folderInfo); 
            #endregion

            #region Subtitles
            //var movieTitle = "Bloodshot.2020.HDRip.XviD.AC3-EVO";
            //var movieTitle2 = "The.Mandalorian.S01E01.WEBRip.x264-ION10";

            var destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MovieSubtitlesCore subtitlesProvider = new MovieSubtitlesCore();

            var testDestination = @"D:\movies\Bloodshot.2020.HDRip.XviD.AC3-EVO";

            var movies = FileExtractor.GetAllContent(testDestination).GetMovies();
            //subtitlesProvider.DownloadSubtitles(movies.First().Name, SubtitleLanguage.bul, movies.First().DirectoryName);

            var subtitles = FileExtractor.GetAllContent(testDestination).GetSubtitles();

            if (movies.First().IdenticalNames(subtitles.First()))
            {
                Console.WriteLine("No need to rename ");
            }
            
            
            

            //subtitles.First().Rename(Path.ChangeExtension(movies.First().FullName, subtitles.First().Extension));
            //Console.WriteLine(movies.First().FullName);
            //Console.WriteLine(subtitles.First().FullName);

            #endregion

            Console.ReadKey();
        }

        

        public static string Indent(int count, string text)
        {
            return "".PadLeft(count) + text;
        }

        public static void CreateShortcuts(DirectoryInfo directory)
        {
            var movies = FileExtractor.GetAllContent(directory.FullName).GetMovies();

            Console.WriteLine("Shortcuts will be created for:");
            Console.WriteLine();
            movies.ForEach(f =>
            {
                Console.WriteLine(f.Name);
            });

            var options = new ShortcutOptions()
            {
                Destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                IsSeries = true,
                UseRealName = false,
                Name = "The Mandalorian"
            };

            movies.Process(options);
        }

        public static void AnalyseDirectory(DirectoryInfo directory)
        {
            var childFolders = directory.GetDirectories();

            Console.WriteLine($"Folders: {childFolders.Length}");

            List<FileInfo> movieFiles = new List<FileInfo>();

            childFolders.ToList().ForEach(f =>
            {
                Console.WriteLine(new String('-', 100));

                Console.WriteLine(f.FullName);
                var folderContent = f.GetFiles().ToList();


                folderContent
                    .ForEach(fc =>
                    {
                        var isMovie = FileValidations.IsMovieFile(fc);
                        Console.ForegroundColor = isMovie ? ConsoleColor.Green : ConsoleColor.Red;
                        Console.WriteLine(Indent(5, $"|_ {fc.Name} | {fc.Extension} | Category Movie: {isMovie}"));
                        if (isMovie)
                            movieFiles.Add(fc);
                    });


                Console.ResetColor();
            });

            Console.WriteLine($"Collected movie files: {movieFiles.Count}");
        }
    }

}
