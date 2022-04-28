using RestaurantSimulator.DOMAIN.Interfaces;

namespace RestaurantSimulator.DOMAIN.Models
{
    public class CookAssistant : Worker, IPrepare
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
