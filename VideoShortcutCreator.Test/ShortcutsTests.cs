using NUnit.Framework;
using System.IO;
using Test.Logic;

namespace VideoShortcutCreator.Test
{
    [TestFixture]
    public class ShortcutsTests
    {
        private FileInfo movie = new FileInfo("The.Mandalorian.S01E05.iNTERNAL.720p.WEB.H264-AMRAP.mp4");
        private FileInfo movie2 = new FileInfo("The.Mandalorian.S0.mp4");

        [Test]
        public void GetSeriesSeasonNumber_WithValidName_ReturnsProperValie()
        {
            var seriesNumber = movie.GetSeriesSeasonNumber(1);

            Assert.That(seriesNumber, Is.EqualTo("S01E05"));
        }

        [Test]
        public void GetSeriesSeasonNumber_WithInValidName_ReturnsIndexValie()
        {
            var seriesNumber = movie2.GetSeriesSeasonNumber(1);

            Assert.That(seriesNumber, Is.EqualTo("01"));
        }
    }
}
