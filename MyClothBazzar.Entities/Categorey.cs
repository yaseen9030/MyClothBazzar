using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClothBazzar.Entities
{
   public class Categorey:BaseEntity 
    {
        public List<Product> ProductsTB { get; set; }
    }
}
