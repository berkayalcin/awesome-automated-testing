using System.Net;
using Awesome_Automated_Test.Mocking.Helpers;
using Moq;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class InstallerHelperTests
    {
        private Mock<IFileDownloader> _fileDownloader;
        private IInstallerHelper _sut;

        [SetUp]
        public void SetUp()
        {
            _fileDownloader = new Mock<IFileDownloader>();
            _sut = new InstallerHelper(_fileDownloader.Object);
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void DownloadInstaller_DownloadFails_ReturnsFalse()
        {
            _fileDownloader.Setup(fd => fd.DownloadFile(It.IsAny<string>(), It.IsAny<string>()))
                .Throws<WebException>();

            var result = _sut.DownloadInstaller(
                It.IsAny<string>(),
                It.IsAny<string>());

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void DownloadInstaller_DownloadCompletes_ReturnsTrue()
        {
            var result = _sut.DownloadInstaller(
                It.IsAny<string>(),
                It.IsAny<string>());

            Assert.That(result, Is.EqualTo(true));
        }
    }
}