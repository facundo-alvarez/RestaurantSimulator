using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator.DOMAIN.Models
{
    public class OrderEventArgs : EventArgs
    {
        public Order Order { get; set; }
    }
}
