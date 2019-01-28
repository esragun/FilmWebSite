using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.Entity
{
    public class Fragman
    {
        public int FragmanID { get; set; }
        public string FragmanURL { get; set; }
        public int FilmID { get; set; }
        public virtual Film Film { get; set; }
    }
}
