namespace RestaurantSimulator.DOMAIN.Models
{
    public class DinnerTable
    {
        int counter;

        public int Id { get; private set; }
        public int NumberOfChairs { get; private set; }
        public bool IsClean { get; set; } = true;
        public bool IsOccupied { get; set; } = false;
        public int IdOfClient { get; set; }

        public DinnerTable(int chairs)
        {
            Id = counter;
            NumberOfChairs = chairs;
            counter++;
        }
    }
}
