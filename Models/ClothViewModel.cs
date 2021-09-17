using Gimli.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gimli.Models
{
    public class ClothViewModel
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
    }
}
