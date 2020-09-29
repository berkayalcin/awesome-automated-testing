using System.Net;

namespace Awesome_Automated_Test.Mocking.Helpers
{
    public class FileDownloader : IFileDownloader
    {
        public void DownloadFile(string url, string path)
        {
            var client = new WebClient();
            client.DownloadFile(
                url,
                path);
        }
    }
}