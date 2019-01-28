using FilmSitesi.DAL.Context;
using FilmSitesi.DAL.IRepositories;
using FilmSitesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DAL.Repositories
{
    public class FilmManagement:ICrud<Film,int>
    {
        FilmSitesiDbContext db = new FilmSitesiDbContext();
        public bool Add(Film obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Film obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<Film> GetAll()
        {
            return db.Filmler.ToList();
        }

        public Film Get(int key)
        {
            return db.Filmler.Where(f => f.FilmID == key).FirstOrDefault();
        }

        public bool Update(Film obj)
        {
            throw new NotImplementedException();
        }
    }
}
