﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSitesi.DAL.IRepositories
{
    interface IAdd<Entity> where Entity:class
    {
        bool Add(Entity obj);
    }
}
