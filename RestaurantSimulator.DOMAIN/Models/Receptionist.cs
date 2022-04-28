namespace RestaurantSimulator.DOMAIN.Models
{
    public class Receptionist : Worker
    {
        public Receptionist(int id, string name, DateOnly birthDate, DateOnly hiredDate, int salary, int workHours) : base(id, name, birthDate, hiredDate, salary, workHours)
        {
        }

        public void AssignTable(Client client, TablesBook tablesBook)
        {
            foreach (DinnerTable dinnerTable in tablesBook.DinnerTables)
            {
                if (!dinnerTable.IsClean || !dinnerTable.IsOccupied)
                    continue;
                else
                    dinnerTable.IdOfClient = client.Id;
                    break;
            }
        }
    }
}
