using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity.Mapping
{
    public class UlkeMapping : EntityTypeConfiguration<Ulke>
    {
        public UlkeMapping()
        {
            this.ToTable("Ulkeler");
            this.HasKey(u => u.UlkeID);
            this.Property(u => u.UlkeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.Property(u => u.UlkeAdi).HasMaxLength(20).IsRequired();
 
        }
    }
}
