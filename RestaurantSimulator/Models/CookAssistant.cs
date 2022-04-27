using RestaurantSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator.Models
{
    sealed class CookAssistant : Worker, IPrepare
    {
        public CookAssistant(int id, string name, DateOnly birthDate, DateOnly hiredDate, int salary, int workHours) : base(id, name, birthDate, hiredDate, salary, workHours)
        {
        }

        public List<Dish> DishesToDo { get; set; }

        public void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
