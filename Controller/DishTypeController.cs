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
        private DishesContext DishDbContext = new DishesContext();
        public List<Dish> GetAllDishes()
        {
            return DishDbContext.Dishes.ToList();
        }
        public string GetDishById(int id)
        {
            return DishDbContext.Dishes.Find(id).Name;
        }
        public List<DishType> GetAllDishTypes()
        {
            return DishDbContext.DishTypes.ToList();



        }
    }
