using RestaurantSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator.Models
{
    sealed class Cleaner : Worker, IClean
    {
        public Cleaner(int id, string name, DateOnly birthDate, DateOnly hiredDate, int salary, int workHours) : base(id, name, birthDate, hiredDate, salary, workHours)
        {
        }

        public void Clean()
        {
            throw new NotImplementedException();
        }
    }
}
