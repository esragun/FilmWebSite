using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity.Mapping
{
    public class PosterMapping : EntityTypeConfiguration<Poster>
    {
        public PosterMapping()
        {
            this.ToTable("Posterler");
            this.HasKey(p => p.PosterID);
            this.Property(p => p.PosterID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(p => p.PosterURL).IsOptional();

            this.Property(p => p.FilmID).IsRequired();
        }
    }
}
