using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSitesi.Entity;
using FilmSitesi.Entity.Mapping;


namespace FilmSitesi.DAL.Context
{
    public class FilmSitesiDbContext:DbContext
    {
        public FilmSitesiDbContext():base("mycon")
        {

        }

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Dil> Diller { get; set; }
        public DbSet<Fragman> Fragman { get; set; }
        public DbSet<Yonetmen> Yonetmen { get; set; }
        public DbSet<Poster> Posterler { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<URL> Urls { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FilmMapping());
            modelBuilder.Configurations.Add(new OyuncuMapping());
            modelBuilder.Configurations.Add(new YonetmenMapping());
            modelBuilder.Configurations.Add(new DilMapping());
            modelBuilder.Configurations.Add(new URLMapping());
            modelBuilder.Configurations.Add(new UlkeMapping());
            modelBuilder.Configurations.Add(new PosterMapping());
            modelBuilder.Configurations.Add(new FragmanMapping());
            modelBuilder.Configurations.Add(new TurMapping());

        }

    }
}
