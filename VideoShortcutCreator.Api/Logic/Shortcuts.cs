using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test.Logic
{
    public static class Shortcuts
    {
        public static void Process(this List<FileInfo> movies, ShortcutOptions options)
        {
            if (movies.Any())
            {
                for (int i = 0; i < movies.Count; i++)
                {
                    var movie = movies[i];
                    var name = options.UseRealName ? movie.Name : options.Name;

                    if (options.IsSeries)
                    {
                        name = movie.GetSeriesSeasonNumber(i) + $" {name}";
                    }

                    Create(name, options.Destination, movie.FullName);
                }
            }
        }

        public static string GetSeriesSeasonNumber(this FileInfo movie, int index)
        {
            var pattern = @"(\D\d{2})";
            var matches = Regex.Matches(movie.Name, pattern);
            if (matches != null && matches.Count > 1)
            {
                return matches[0].Value + matches[1].Value;
            }

            return index.ToString("D2");
        }

        private static void Create(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            //shortcut.Description = "My shortcut description";
            //shortcut.IconLocation = @"c:\myicon.ico";
            shortcut.TargetPath = targetFileLocation;
            shortcut.Save();
        }
    }
}
