namespace RestaurantSimulator.DOMAIN.Models
{
    public class Food
    {
        public string Name { get; }
        public decimal Price { get; }

        public Food(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}