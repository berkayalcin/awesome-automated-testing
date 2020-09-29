using System.IO;

namespace Awesome_Automated_Test.Mocking.Video
{
    public class FileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}