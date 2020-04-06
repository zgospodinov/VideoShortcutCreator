using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Logic
{
    public static class FileExtensions
    {
        public static void Rename(this FileInfo fileInfo, string newName) => fileInfo.MoveTo(newName);

        public static bool IdenticalNames(this FileInfo source, FileInfo target)
        {
            var sourceName = Path.GetFileNameWithoutExtension(source.Name);
            var targetName = Path.GetFileNameWithoutExtension(target.Name);

            return sourceName == targetName;
        }
    }
}
