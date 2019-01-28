using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Dil
    {
        public int DilID { get; set; }
        public string DilAdi { get; set; }
        public virtual ICollection<Film> Filmler { get; set; }
    }
}
