using FilmSitesi.DAL.Repositories;
using FilmSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.BLL
{
    public class FilmController
    {
        FilmManagement fm = new FilmManagement();

        public List<Film> FilmleriListele()
        {
            return fm.GetAll();
        }

        public string FilmAnaFragmanGetir(int FilmID)
        {
            string fragmanLink = fm.Get(FilmID).Fragmanlar.FirstOrDefault().FragmanURL;
            return fragmanLink;
        }

       
    }
}
