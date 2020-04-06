using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VideoShortcutCreator.Api.Logic;

namespace Test.Logic
{
    public static class FileExtractor
    {
        public static List<FileInfo> GetAllContent(string sDir)
        {
            List<FileInfo> files = new List<FileInfo>();
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    files.Add(new FileInfo(f));
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    files.AddRange(GetAllContent(d));
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }

            return files;
        }

        public static List<FileInfo> GetMovies(this List<FileInfo> content)
        {
            return content.Where(c => FileValidations.IsMovieFile(c)).ToList();
        }

        public static IEnumerable<FileInfo> GetSubtitles(this IEnumerable<FileInfo> content) => content.Where(c => c.IsSubtitleFile()).AsEnumerable();
    }
}
