using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity.Mapping
{
    public class OyuncuMapping : EntityTypeConfiguration<Oyuncu>
    {
        public OyuncuMapping()
        {
            this.ToTable("Oyuncular");
            this.HasKey(o => o.OyuncuID);
            this.Property(o=>o.OyuncuID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(o=>o.OyuncuAd).HasMaxLength(50).IsRequired();

            this.Property(o => o.OyuncuSoyad).HasMaxLength(50).IsRequired();
        }
    }
}
