using RestaurantSimulator.DOMAIN.Interfaces;

namespace RestaurantSimulator.DOMAIN.Models
{
    public class Server : Worker, IClean
    {
        public Server(int id, string name, DateOnly birthDate, DateOnly hiredDate, int salary, int workHours) : base(id, name, birthDate, hiredDate, salary, workHours)
        {
        }

        public int Rating { get; set; }

        public void Clean()
        {
            throw new NotImplementedException();
        }

        public bool CheckOrder(int table)
        {
            if (KitchenCounter.ordersReady.Count != 0)
            {
                var isReady = KitchenCounter.ordersReady.First().TableId == table;
                return isReady;
            }
            return false;

        }

        public void ServePlate(int table)
        {
            Order order = KitchenCounter.ordersReady.Where(x => x.TableId == table).Single();
            KitchenCounter.ordersReady.Remove(order);
            Console.WriteLine($"Taking food to the table {table}");
        }
    }
}
