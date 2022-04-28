namespace RestaurantSimulator.DOMAIN.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Food FoodType { get; set; }
        public int TableId { get; set; }

        public Order(int orderId, Food food, int tableId)
        {
            OrderId = orderId;
            FoodType = food;
            TableId = tableId;
        }
    }
}
