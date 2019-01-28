using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Ulke
    {
        public Ulke()
        {
            Filmler = new HashSet<Film>();
        }
        public int UlkeID { get; set; }
        public string UlkeAdi { get; set; }

        public virtual ICollection<Film> Filmler { get; set; }
    }
}
