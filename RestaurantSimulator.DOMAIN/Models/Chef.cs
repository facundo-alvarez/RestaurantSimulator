namespace RestaurantSimulator.DOMAIN.Models
{
    public class Chef : Worker
    {
        public delegate void FoodPreparedHandler(object source, OrderEventArgs args);
        public event FoodPreparedHandler FoodPrepared;

        public Chef(int id, string name, DateOnly birthDate, DateOnly hiredDate, int salary, int workHours) : base(id, name, birthDate, hiredDate, salary, workHours)
        {

        }

        public async void CookFood(Order order)        {
            Console.WriteLine($"Chef Recieved an order for: {order.FoodType.Name}");
            Console.WriteLine("Delegating to the cook...");
            Task.Delay(2000);
            OnFoodPrepared(order);
            Task.Delay(2000);
            Console.Clear();
        }  

        protected virtual void OnFoodPrepared(Order order)
        {
            if (FoodPrepared != null)
                FoodPrepared(this, new OrderEventArgs() { Order = order });
            
        }
    }
}
