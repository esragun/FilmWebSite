using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity.Mapping
{
    public class DilMapping : EntityTypeConfiguration<Dil>
    {
        public DilMapping()
        {
            this.ToTable("Diller");
            this.HasKey(d => d.DilID);
            this.Property(d => d.DilID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(d=>d.DilAdi).HasMaxLength(20).IsRequired();
        }
    }
}
