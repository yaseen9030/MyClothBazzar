using MyClothBazzar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClothBazzar.DataBase
{
    public class MyClothBazzarContext:DbContext
    {
        public MyClothBazzarContext()
            :base("MyClothBazzarConnection")
        {
        }
        
        public DbSet<Categorey> Categories  { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
