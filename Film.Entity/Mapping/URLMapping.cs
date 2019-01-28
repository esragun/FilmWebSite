using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity.Mapping
{
    public class URLMapping : EntityTypeConfiguration<URL>
    {
        public URLMapping()
        {
            this.ToTable("URLs");
            this.HasKey(u => u.UrlID);
            this.Property(u => u.UrlID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(u => u.UrlLink).IsRequired();

            this.Property(u => u.UrlAciklama).HasMaxLength(200).IsRequired();

            this.Property(u => u.FilmID).IsRequired();
        }
    }
}
