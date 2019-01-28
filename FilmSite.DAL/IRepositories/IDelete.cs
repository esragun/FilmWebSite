using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DAL.IRepositories
{
    interface IDelete<Entity,key> where Entity:class
    {
        bool Delete(Entity obj);
        bool Delete(key key);
    }
}
