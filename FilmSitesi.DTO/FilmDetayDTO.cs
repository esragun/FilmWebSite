using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DTO
{
    public class FilmDetayDTO
    {
        public string FilmAdi { get; set; }
        public string Yil { get; set; }
        public string Aciklama { get; set; }
        public int Sure { get; set; }
        public string Dil { get; set; }
        public string PosterURL { get; set; }

    }
}
