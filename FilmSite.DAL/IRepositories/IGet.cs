using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DAL.IRepositories
{
    interface IGet<Entity,key> where Entity:class
    {
        List<Entity> GetAll();
        Entity Get(key key);
    }
}
