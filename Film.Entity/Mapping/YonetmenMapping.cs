using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity.Mapping
{
    public class YonetmenMapping : EntityTypeConfiguration<Yonetmen>
    {
        public YonetmenMapping()
        {
            this.ToTable("Yonetmenler");
            this.HasKey(y => y.YonetmenID);
            this.Property(y => y.YonetmenID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(y => y.YonetmenAd).HasMaxLength(50).IsRequired();

            this.Property(y => y.YonetmenSoyad).HasMaxLength(50).IsRequired();
        }
    }
}
