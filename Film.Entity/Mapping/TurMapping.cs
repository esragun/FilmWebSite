using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity.Mapping
{
    public class TurMapping : EntityTypeConfiguration<Tur>
    {
        public TurMapping()
        {
            this.ToTable("Turler");
            this.HasKey(t => t.TurID);

            this.Property(t => t.TurID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(t => t.TurAdi).HasMaxLength(20).IsRequired();
        }
    }
}
