using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMusic.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMusicContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMusicContext>>()))
            {
                // Look for any movies.
                if (context.Album.Any())
                {
                    return;   // DB has been seeded
                }

                context.Album.AddRange(
                    new Album
                    {
                        Author = "Anthony Gomes",
                        AlbumName = "Peace, Love, and Loud Guitars",
                        ReleaseDate = DateTime.Parse("2018-2-12"),
                        Genre = "Blues",
                        Price = 7.99M
                    },

                    new Album
                    {
                        Author = "Neil Young",
                        AlbumName = "After the Gold Rush",
                        ReleaseDate = DateTime.Parse("1970-3-13"),
                        Genre = "Folk",
                        Price = 8.99M
                    },

                    new Album
                    {
                        Author = "Iggy Pop",
                        AlbumName = "The Idiot",
                        ReleaseDate = DateTime.Parse("1977-2-23"),
                        Genre = "Rock",
                        Price = 9.99M
                    },

                    new Album
                    {
                        Author = "Led Zeppelin",
                        AlbumName = "Physical Graffiti",
                        ReleaseDate = DateTime.Parse("1975-4-15"),
                        Genre = "Rock",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}