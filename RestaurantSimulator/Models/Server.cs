using RestaurantSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator.Models
{
    sealed class Server : Worker, IClean, IPrepare
    {
        public Server(int id, string name, DateOnly birthDate, DateOnly hiredDate, int salary, int workHours) : base(id, name, birthDate, hiredDate, salary, workHours)
        {
        }

        public int TablesServed { get; set; }
        public int Rating { get; set; }

        public void Clean()
        {
            throw new NotImplementedException();
        }

        public void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
