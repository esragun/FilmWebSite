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
    public class PosterManagement:ICrud<Poster,int>
    {
        FilmSitesiDbContext db = new FilmSitesiDbContext();
        public bool Add(Poster obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Poster obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<Poster> GetAll()
        {
            throw new NotImplementedException();
        }

        public Poster Get(int key)
        {
            return db.Posterler.Where(p => p.FilmID == key).FirstOrDefault();
        }

        public bool Update(Poster obj)
        {
            throw new NotImplementedException();
        }
    }
}
