using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Yonetmen
    {
        public Yonetmen()
        {
            Filmler = new HashSet<Film>();
        }
        public int YonetmenID { get; set; }
        public string YonetmenAd { get; set; }
        public string YonetmenSoyad { get; set; }

        public virtual ICollection<Film> Filmler { get; set; }
    }
}
