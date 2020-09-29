using Awesome_Automated_Test.Mocking.Video;
using Moq;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests.MockingTests
{
    [TestFixture]
    public class VideoServiceTests
    {
        private VideoService _sut;
        private Mock<IFileReader> _fileReader;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            _sut = new VideoService(_fileReader.Object);
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

    }
}