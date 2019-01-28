using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Oyuncu
    {
        public Oyuncu()
        {
            Filmler = new HashSet<Film>();
        }
        public int OyuncuID { get; set; }
        public string OyuncuAd { get; set; }
        public string OyuncuSoyad { get; set; }
        public virtual ICollection<Film> Filmler { get; set; }
    }
}
