using System.IO;
using VideoShortcutCreator.Api.Enums;

namespace VideoShortcutCreator.Api.Logic
{
    public static class FileValidations
    {
        public static bool IsMovieFile(this FileInfo file)
        {
            return Enum<VideoFormats>.Values.Contains(file.Extension.TrimStart('.'));
        }
    }
}
