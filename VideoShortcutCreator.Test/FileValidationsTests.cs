using System.IO;
using NUnit.Framework;
using VideoShortcutCreator.Api.Logic;
using Assert = NUnit.Framework.Assert;

namespace VideoShortcutCreator.Test
{
    [TestFixture]
    public class FileValidationsTests
    {
        [Test]
        public void ValidMediaFile_ShouldValidate_True()
        {
            Assert.IsTrue(FileValidations.IsMovieFile(new FileInfo("testVideo.mp4")));
            Assert.IsTrue(FileValidations.IsMovieFile(new FileInfo("testVideo.mkv")));
        }

        [Test]
        public void InValidMediaFile_ShouldValidate_False()
        {
            Assert.IsFalse(FileValidations.IsMovieFile(new FileInfo("testVideo.txt")));
            Assert.IsFalse(FileValidations.IsMovieFile(new FileInfo("testVideo.lnk")));
        }

    }
}
