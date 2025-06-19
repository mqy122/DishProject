﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Data
{
    public class Dish
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
       public int DishtypeID { get; set; }
        public DishType DishType { get; set; }
    }
}
