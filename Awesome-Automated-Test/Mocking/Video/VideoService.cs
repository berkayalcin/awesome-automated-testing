using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Awesome_Automated_Test.Mocking.Video
{
    public class VideoService
    {
        private readonly IFileReader _fileReader;

        public VideoService(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public string ReadVideoTitle()
        {
            var str = _fileReader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();

            using var context = new VideoContext();
            var videos =
                (from video in context.Videos
                    where !video.IsProcessed
                    select video).ToList();

            foreach (var v in videos)
                videoIds.Add(v.Id);

            return String.Join(",", videoIds);
        }
    }
}