using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity.Mapping
{
    public class FilmMapping:EntityTypeConfiguration<Film>
    {
        
        public FilmMapping()
        {
            this.ToTable("Filmler");
            this.HasKey(f => f.FilmID);
            this.Property(f => f.FilmID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(f => f.FilmAdi).HasMaxLength(100).IsRequired();

            this.Property(f => f.Aciklama).HasMaxLength(200).IsRequired();

            this.Property(f => f.FilmSure).IsRequired();

            this.Property(f => f.DilID).IsRequired();

            this.Property(f => f.YapimYili).IsRequired();

            this.HasMany(f => f.Oyuncular)
                .WithMany(o => o.Filmler)
                .Map(t =>
                {
                    t.MapLeftKey("FilmID");
                    t.MapRightKey("OyuncuID");
                    t.ToTable("FilmOyuncu");
                });

            this.HasMany(f => f.Yonetmenler)
                .WithMany(y => y.Filmler)
                .Map(t =>
                {
                    t.MapLeftKey("FilmID");
                    t.MapRightKey("YonetmenID");
                    t.ToTable("FilmYonetmen");
                });

            this.HasMany(f => f.Ulkeler)
                .WithMany(u => u.Filmler)
                .Map(t =>
                {
                    t.MapLeftKey("FilmID");
                    t.MapRightKey("UlkeID");
                    t.ToTable("UlkeFilm");
                });

            this.HasMany(f => f.Turler)
                .WithMany(t => t.Filmler)
                .Map(t =>
                {
                    t.MapLeftKey("FilmID");
                    t.MapRightKey("TurID");
                    t.ToTable("TurFilm");
                });

            this.HasMany(f => f.Posterler)
                .WithRequired(p => p.Film)
                .HasForeignKey(p => p.FilmID);

            this.HasMany(f => f.Urls)
               .WithRequired(u => u.Film)
               .HasForeignKey(u => u.FilmID);

            this.HasMany(f => f.Fragmanlar)
              .WithRequired(fr => fr.Film)
              .HasForeignKey(fr => fr.FilmID);

            this.HasRequired(f => f.Dil)
                .WithMany(d => d.Filmler)
                .HasForeignKey(f => f.DilID);
        }
    }
}
