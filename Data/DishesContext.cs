using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Data
{
    public class DishesContext:DbContext
    {
        public DishesContext(): base ("DishesContext")
        {

        }
        public DbSet<DishType> DishTypes { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        
    }
}
