using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator.Models
{
    public class Dish : Food
    {
        public int NumberOfIngrediendts { get; set; }
        public List<Ingridient> Ingridients { get; set; }
    }
}
