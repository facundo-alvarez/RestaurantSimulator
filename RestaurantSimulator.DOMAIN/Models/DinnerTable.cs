namespace RestaurantSimulator.DOMAIN.Models
{
    public class DinnerTable
    { 
        public int Id { get; private set; }
        public int NumberOfChairs { get; private set; }
        public bool IsClean { get; set; } = true;
        public bool IsOccupied { get; set; } = false;
        public int IdOfClient { get; set; }

        public DinnerTable(int id, int chairs)
        {
            Id = id;
            NumberOfChairs = chairs;
        }
    }
}
