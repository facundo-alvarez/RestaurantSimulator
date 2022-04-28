using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator.DOMAIN.Models
{
    public class WaitingLine
    {
        public List<Client> ClientsWaiting { get; set; } = new List<Client>();

        public int CountClientsWaiting() => ClientsWaiting.Count();
        public void RemoveClient(Client c) => ClientsWaiting.Remove(c);
    }
}
