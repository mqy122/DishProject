using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes.Data
{
    public class DishType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<DishType> Dishes { get; set; }
    }
}
