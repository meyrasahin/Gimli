using Gimli.Data.Entities;
using Gimli.Data.Entities.MyClothClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gimli.Models
{
    public class OutfitViewModel
    {
        public Outfit Outfit { get; set; }
        public List<HeadClothes> HeadClothes { get; set; } = new List<HeadClothes>();
        public List<ArmClothes> ArmClothes { get; set; } = new List<ArmClothes>();
        public List<BodyClothes> BodyClothes { get; set; } = new List<BodyClothes>();
        public List<LegsClothes> LegsClothes { get; set; } = new List<LegsClothes>();
        public List<FeetClothes> FeetClothes { get; set; } = new List<FeetClothes>();
    }
}
