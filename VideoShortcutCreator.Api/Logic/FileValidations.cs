using System.IO;
using VideoShortcutCreator.Api.Enums;

namespace VideoShortcutCreator.Api.Logic
{
    public static class FileValidations
    {
        public static bool IsMovieFile(this FileInfo file) => Enum<VideoFormats>.Values.Contains(file.Extension.TrimStart('.'));

        public static bool IsSubtitleFile(this FileInfo file) => Enum<SubtitleFormats>.Values.Contains(file.Extension.TrimStart('.'));
    }
}
