using System.Collections.Generic;
using Awesome_Automated_Test.Mocking.Video;
using Moq;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class VideoServiceTests
    {
        private VideoService _sut;
        private Mock<IFileReader> _fileReader;
        private Mock<IVideoRepository> _videoRepository;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            _videoRepository = new Mock<IVideoRepository>();
            _sut = new VideoService(_fileReader.Object, _videoRepository.Object);
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void ReadVideoTitle_IsVideoNull_ReturnsEmptyString()
        {
            _fileReader.Setup(r => r.Read("video.txt")).Returns("");
            var result = _sut.ReadVideoTitle();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_AllVideosProcessed_ReturnsEmptyString()
        {
            _videoRepository.Setup(v => v.GetVideos(false)).Returns(new List<Video>());

            var csv = _sut.GetUnprocessedVideosAsCsv();

            Assert.That(csv, Is.EqualTo(""));
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_AFewUnprocessedVideos_ReturnAStringWithIdOfUnprocessedVideos()
        {
            _videoRepository.Setup(v => v.GetVideos(false)).Returns(new List<Video>()
            {
                new Video() {Id = 1, Title = "", IsProcessed = false},
                new Video() {Id = 2, Title = "", IsProcessed = false},
                new Video() {Id = 3, Title = "", IsProcessed = false},
            });

            var csv = _sut.GetUnprocessedVideosAsCsv();


            Assert.That(csv, Is.EqualTo("1,2,3"));
        }
    }
}