namespace RestaurantSimulator.DOMAIN.Models
{
    public class Chef : Worker
    {
        public int PlatesSupervised { get; set; }

        public Chef(int id, string name, DateOnly birthDate, DateOnly hiredDate, int salary, int workHours) : base(id, name, birthDate, hiredDate, salary, workHours)
        {

        }
    }
}
