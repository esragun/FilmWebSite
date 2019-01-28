using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Tur
    {
        public Tur()
        {
            Filmler = new HashSet<Film>();
        }
        public int TurID { get; set; }
        public string TurAdi { get; set; }

        public virtual ICollection<Film> Filmler { get; set; }
    }
}
