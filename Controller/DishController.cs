using System;
using System.Collections.Generic;
using System.Linq;
using Dishes.Data;

namespace Dishes.Controller
{
    internal class DishController
    {
        private DishesContext dishesDbContext = new DishesContext();

      

        public Dish Get(int id)
        {
            var dish = dishesDbContext.Dishes.Find(id);
            if (dish == null)
            {
                dishesDbContext.Entry(dish).Reference(x => x.DishType).Load();
            }
            return dish;
        }

        public List<Dish> GetAll()
        {
            return dishesDbContext.Dishes.Include("Dishes").ToList();
        }

        public void Create(Dish dish)
        {
            dishesDbContext.Dishes.Add(dish);
            dishesDbContext.SaveChanges();
        }

        public void Update(int id, Dish dish)
        {
            var existingDish = dishesDbContext.Dishes.Find(id);
            if (existingDish == null)
            {
                return;
            }
            existingDish.Name = dish.Name;
            existingDish.Description = dish.Description;
            existingDish.Price = dish.Price;
            
            dishesDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var dish = dishesDbContext.Dishes.Find(id);
            if (dish == null)
            {
                return;
            }
            dishesDbContext.Dishes.Remove(dish);
            dishesDbContext.SaveChanges();
        }
    }
}



