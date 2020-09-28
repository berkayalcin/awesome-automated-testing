using System;
using Microsoft.EntityFrameworkCore;

namespace Awesome_Automated_Test.Mocking.Video
{
    public class VideoContext : DbContext, IDisposable
    {
        public DbSet<Video> Videos { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}