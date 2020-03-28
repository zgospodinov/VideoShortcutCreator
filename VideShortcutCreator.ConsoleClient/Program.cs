using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Test.Logic;
using VideoShortcutCreator.Api.Logic;

namespace VideShortcutCreator.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test directory
            string rootDirectory = @"D:\movies\Shortcuts testing";

            var folderInfo = new DirectoryInfo(rootDirectory);

            //AnalyseDirectory(folderInfo);

            CreateShortcuts(folderInfo);

            Console.ReadKey();
        }

        public static string Indent(int count, string text)
        {
            return "".PadLeft(count) + text;
        }

        public static void CreateShortcuts(DirectoryInfo directory)
        {

            var movies = FileExtractor.GetAllContent(directory.FullName).GetMovies();
            Console.WriteLine(movies.Count);
            Console.WriteLine();
            movies.ForEach(f =>
            {
                Console.WriteLine(f.Name);
            });


            for (int i = 0; i < movies.Count; i++)
            {
                Shortcuts.Create($"my shortcut {i}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), movies[i].FullName);
            }
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
