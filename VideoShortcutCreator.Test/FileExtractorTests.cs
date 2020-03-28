using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Logic;

namespace VideoShortcutCreator.Test
{
    [TestFixture]
    public class FileExtractorTests
    {
        private static string rootDir = @"D:\movies\Shortcuts testing";

        [Test]
        public static void GetAllContent_ShouldReturnAll()
        {
            var content = FileExtractor.GetAllContent(rootDir);

            Assert.That(content.Count, Is.EqualTo(7));
        }

        [Test]
        public static void GetMovies_ShouldReturn_ProperAmount()
        {
            var movies = FileExtractor.GetAllContent(rootDir).GetMovies();

            Assert.That(movies.Count, Is.EqualTo(5));
        }
    }
}
