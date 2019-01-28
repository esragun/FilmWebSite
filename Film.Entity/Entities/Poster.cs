using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Poster
    {
        public int PosterID { get; set; }
        public string PosterURL { get; set; }
        public int FilmID { get; set; }
        public virtual Film Film { get; set; }
    }
}
