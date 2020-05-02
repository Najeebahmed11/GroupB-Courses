using Moq;
using NUnit.Framework;
using System.Net;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class InstallerHelperTest
    {
        private Mock<IFileDownLoader> _fileDownloader;
        private InstallerHelper _installerHelper;

        [SetUp]
        public void Setup()
        {
            _fileDownloader = new Mock<IFileDownLoader>();
            _installerHelper = new InstallerHelper(_fileDownloader.Object);

        }
        [Test]
        public void DownloadInstaller_DownlaodFails_ReturnFalse()
        {
            _fileDownloader.Setup(fd =>
            fd.DownlaodFile(It.IsAny<string>(), It.IsAny<string>()))
                .Throws<WebException>();
            var result=_installerHelper.DownloadInstaller("customer", "installer");
            Assert.That(result, Is.False);
        }
        [Test]
        public void DownloadInstaller_DownlaodComplete_ReturnTrue()
        {
            
            var result = _installerHelper.DownloadInstaller("customer", "installer");
            Assert.That(result, Is.True);
        }
    }
}
