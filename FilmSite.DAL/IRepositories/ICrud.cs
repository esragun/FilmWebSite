using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DAL.IRepositories
{
    interface ICrud<Entity,key>:IAdd<Entity>,IDelete<Entity,key>,IGet<Entity,key>,IUpdate<Entity> where Entity:class
    {
    }
}
