using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMusic.Models;

namespace MvcMusic.Models
{
    public class MvcMusicContext : DbContext
    {
        public MvcMusicContext (DbContextOptions<MvcMusicContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMusic.Models.Album> Album { get; set; }
    }
}
