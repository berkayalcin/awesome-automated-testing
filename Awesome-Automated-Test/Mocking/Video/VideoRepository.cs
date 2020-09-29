using System.Collections.Generic;
using System.Linq;

namespace Awesome_Automated_Test.Mocking.Video
{
    public class VideoRepository : IVideoRepository
    {
        public IEnumerable<Video> GetVideos(bool? isProcessed = false)
        {
            using var context = new VideoContext();
            var videos =
                (from video in context.Videos
                    where !video.IsProcessed
                    select video).ToList();
            return videos;
        }
    }
}