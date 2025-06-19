using Dishes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Controller
{ }
    public class DishTypeController
    {
        private DishesContext vegandbcontex = new DishesContext();
        public List<Dish> GetAllVegans()
        {
            return vegandbcontex.Dishes.ToList();
        }
        public string GetDishById(int id)
        {
            return vegandbcontex.Dishes.Find(id).Name;
        }
        public List<DishType> GetAllVeganTypes()
        {
            return vegandbcontex.DishTypes.ToList();



        }
    }
