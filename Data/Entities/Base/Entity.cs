using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gimli.Data.Entities.Base
{
    public abstract class Entity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }

    public abstract class Entity: Entity<int>
    {

    }
}
