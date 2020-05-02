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
        private Mock<IFileReader> _fileReader;
        private Mock<IVideoRepository> _repository;
        private VideoService _videoservice;

        [SetUp]
        public void Setup()
        {
             _fileReader = new Mock<IFileReader>();
            _repository = new Mock<IVideoRepository>();
             _videoservice = new VideoService(_fileReader.Object,_repository.Object);
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
        [Test]
        public void GetUnProcessedVideosAsCsv_AllVideosAreUnProcessed_ReturnAnEmptyString()
        {
            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video>());
            var result=_videoservice.GetUnprocessedVideosAsCsv();
            Assert.That(result, Is.EqualTo(""));
        }
        [Test]
        public void GetUnProcessedVideosAsCsv_AllVideosAreUnProcessed_AFewUnProcessedVideos_ReturnAStringWithIdOfUnProcessedVideos()
        {
            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video> {
                new Video{Id=1},
                new Video{Id=2},
                new Video{Id=3},
            });
            var result = _videoservice.GetUnprocessedVideosAsCsv();
            Assert.That(result, Is.EqualTo("1,2,3"));
        }
    }
}
