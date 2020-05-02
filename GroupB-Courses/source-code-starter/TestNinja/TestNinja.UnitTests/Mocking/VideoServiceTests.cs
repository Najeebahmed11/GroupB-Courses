using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class VideoServiceTests
    {

        [SetUp]
        public void Setup()
        {
            var _fileReader = new Mock<IFileReader>();
            var _videoservice = new VideoService(_fileReader.Object);
        }
        [Test]
        public void ReadVideoTittle_EmptyFile_ReturnError()
        {
            var _fileReader = new Mock<IFileReader>();
            var _videoservice = new VideoService(_fileReader.Object);
            _fileReader.Setup(fr => fr.Read("Video.txt")).Returns("");
            
            var result=_videoservice.ReadVideoTitle();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
