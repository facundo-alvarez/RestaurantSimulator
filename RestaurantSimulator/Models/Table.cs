using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator.Models
{
    sealed class Table
    {
        int counter;

        public int Number { get; private set; }
        public bool IsClean { get; set; } = true;

        public Table()
        {
            Number = counter;
            counter++;
        }
    }
}
