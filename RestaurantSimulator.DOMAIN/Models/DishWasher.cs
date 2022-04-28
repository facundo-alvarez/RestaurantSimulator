using RestaurantSimulator.DOMAIN.Interfaces;

namespace RestaurantSimulator.DOMAIN.Models
{
    public class DishWasher : Worker, IClean
    {
        public DishWasher(int id, string name, DateOnly birthDate, DateOnly hiredDate, int salary, int workHours) : base(id, name, birthDate, hiredDate, salary, workHours)
        {
        }

        public void Clean()
        {
            throw new NotImplementedException();
        }
    }
}
