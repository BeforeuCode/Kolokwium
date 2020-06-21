using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class MusicDbContext : DbContext
    {
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Musician_Track> MusicianTrack { get; set; }

        public MusicDbContext()
        {

        }

        public MusicDbContext(DbContextOptions options) : base(options) {}
    }
}
