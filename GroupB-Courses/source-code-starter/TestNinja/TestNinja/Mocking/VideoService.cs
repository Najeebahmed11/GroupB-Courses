using System;
using System.Collections.Generic;
using System.Data.Entity;
using Newtonsoft.Json;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        private IFileReader _fiereader;
        private IVideoRepository _repository;


        public VideoService(IFileReader filereader = null, IVideoRepository repository = null)
        {
            _fiereader = filereader ?? new FileReader();
            _repository = repository ?? new VideoRepository();
        }
        public string ReadVideoTitle()
        {
            //method parameter
            var str = _fiereader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        public string GetUnprocessedVideosAsCsv()
        {
            var videos = _repository.GetUnprocessedVideos();
            var videoIds = new List<int>();
            foreach (var v in videos)
                    videoIds.Add(v.Id);

                return String.Join(",", videoIds);
            
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}