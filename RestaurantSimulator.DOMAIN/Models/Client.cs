namespace RestaurantSimulator.DOMAIN.Models
{
    public class Client
    {
        public int Id { get; set; }
        public int NumberOfPeople { get; set; }

        public Client(int id, int numb)
        {
            Id = id;
            NumberOfPeople = numb;
        }

        public Food Order(Menu menuList, int item) => menuList.FoodMenu[item];

        public void Eat() => Console.WriteLine("Eating");

        public void AskCheck()
        {

        }

        public void Leave()
        {

        }
    }
}
