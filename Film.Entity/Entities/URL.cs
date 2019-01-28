using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class URL
    {
        public int UrlID { get; set; }
        public string UrlLink { get; set; }
        public string UrlAciklama { get; set; }
        public int FilmID { get; set; }
        public virtual Film Film { get; set; }
    }
}
