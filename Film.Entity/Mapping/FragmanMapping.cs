using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity.Mapping
{
    public class FragmanMapping : EntityTypeConfiguration<Fragman>
    {
        public FragmanMapping()
        {
            this.ToTable("Fragmanlar");
            this.HasKey(f => f.FragmanID);
            this.Property(f => f.FragmanID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(f => f.FragmanURL).IsRequired();

            this.Property(f => f.FilmID).IsRequired();
        }
    }
}
