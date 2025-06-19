using System;
using System.Collections.Generic;
using System.Linq;
using Dishes.Data;

namespace Dishes.Controller
{
    internal class DishController
    {
        private DishesContext DishDbContext = new DishesContext();

      

        public Dish Get(int id)
        {
            var dish = DishDbContext.Dishes.Find(id);
            if (dish == null)
            {
                DishDbContext.Entry(dish).Reference(x => x.DishType).Load();
            }
            return dish;
        }

        public List<Dish> GetAll()
        {
            return DishDbContext.Dishes.Include("Dishes").ToList();
        }

        public void Create(Dish dish)
        {
            DishDbContext.Dishes.Add(dish);
            DishDbContext.SaveChanges();
        }

        public void Update(int id, Dish dish)
        {
            var existingDish = DishDbContext.Dishes.Find(id);
            if (existingDish == null)
            {
                return;
            }
            existingDish.Name = dish.Name;
            existingDish.Description = dish.Description;
            existingDish.Price = dish.Price;
            
            DishDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var dish = DishDbContext.Dishes.Find(id);
            if (dish == null)
            {
                return;
            }
            DishDbContext.Dishes.Remove(dish);
            DishDbContext.SaveChanges();
        }
    }
}



