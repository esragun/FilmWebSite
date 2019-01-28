using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Film
    {
        public Film()
        {
            Oyuncular = new HashSet<Oyuncu>();
            Yonetmenler = new HashSet<Yonetmen>();
            Turler = new HashSet<Tur>();
            Ulkeler = new HashSet<Ulke>();
            Posterler = new HashSet<Poster>();
            Urls = new HashSet<URL>();
            Fragmanlar = new HashSet<Fragman>();
        }
        public int FilmID { get; set; }
        public string FilmAdi { get; set; }
        public DateTime YapimYili { get; set; }
        public string Aciklama { get; set; }
        public int FilmSure { get; set; }
        public int DilID { get; set; }
        
        public virtual ICollection<Oyuncu> Oyuncular { get; set; }
        public virtual ICollection<Yonetmen> Yonetmenler { get; set; }
        public virtual ICollection<Tur> Turler { get; set; }
        public virtual ICollection<Ulke> Ulkeler { get; set; }
        public virtual ICollection<Poster> Posterler { get; set; }
        public virtual ICollection<URL> Urls { get; set; }
        public virtual ICollection<Fragman> Fragmanlar { get; set; }
        public virtual Dil Dil { get; set; }




    }
}
