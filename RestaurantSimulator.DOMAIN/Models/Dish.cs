namespace RestaurantSimulator.DOMAIN.Models
{
    public class Dish : Food
    {
        public int NumberOfIngrediendts { get; set; }
        public List<Ingridient> Ingridients { get; set; }
    }
}
