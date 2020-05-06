using System;
using System.Data.Entity;
using static EntityApp.Program.Album;

namespace EntityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MusicContext())
            {
                var albums = context.Albums;
            }
        }

        public class Album
        {
            public int AlbumId { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }

            public class MusicContext : DbContext
            {
                public DbSet<Album> Albums { get; set; }
            }
        }
    }
}