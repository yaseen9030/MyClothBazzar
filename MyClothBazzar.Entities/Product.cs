using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClothBazzar.Entities
{
    public class Product:BaseEntity
    {
        public int Size { get; set; }
        public decimal Price { get; set; }
        public Categorey  CategoreysTB { get; set; }
    }
}
