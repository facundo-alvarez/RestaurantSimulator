using RestaurantSimulator.DOMAIN.Interfaces;

namespace RestaurantSimulator.DOMAIN.Models
{
    public class CookAssistant : Worker
    {
        public CookAssistant(int id, string name, DateOnly birthDate, DateOnly hiredDate, int salary, int workHours) : base(id, name, birthDate, hiredDate, salary, workHours)
        {
        }

        public async void OnFoodPreparation(object source, OrderEventArgs e)
        {
            Console.Clear();
            Console.WriteLine($"Preparing the {e.Order.FoodType.Name}...");
            await Task.Delay(10000);
            Console.WriteLine("The Food is ready!");
            KitchenCounter.ordersReady.Add(e.Order);
        }
    }
}
