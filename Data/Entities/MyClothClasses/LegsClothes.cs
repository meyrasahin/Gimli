using Gimli.Data.Entities.Enums;
using Gimli.Data.Entities.MyClothClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gimli.Data.Entities.MyClothClasses
{
    public class LegsClothes: Cloth
    {
        public LegsClothType Type { get; set; }
    }
}
