using RestaurantSimulator.DOMAIN.Interfaces;

namespace RestaurantSimulator.DOMAIN.Models
{
    public class Server : Worker, IClean, IPrepare
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
