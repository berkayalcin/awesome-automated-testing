using System.Collections.Generic;

namespace Awesome_Automated_Test.Mocking.Video
{
    public interface IVideoRepository
    {
        IEnumerable<Video> GetVideos(bool? isProcessed = false);
    }
}