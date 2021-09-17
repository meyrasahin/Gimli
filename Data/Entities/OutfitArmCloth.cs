using Gimli.Data.Entities.Base;
using Gimli.Data.Entities.MyClothClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gimli.Data.Entities
{
    public class OutfitArmCloth:Entity
    {
        public int OutfitId { get; set; }

        public int ArmClothId { get; set; }

    }
}
