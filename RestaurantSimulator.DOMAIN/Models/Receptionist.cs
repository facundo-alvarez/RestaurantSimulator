namespace RestaurantSimulator.DOMAIN.Models
{
    public class Receptionist : Worker
    {
        public Receptionist(int id, string name, DateOnly birthDate, DateOnly hiredDate, int salary, int workHours) : base(id, name, birthDate, hiredDate, salary, workHours)
        {

        }

        public void AssignTable(WaitingLine waitingLine, TablesBook tablesBook)
        {
            foreach (var client in waitingLine.ClientsWaiting)
            {
                foreach (var table in tablesBook.DinnerTables)
                {
                    if ((client.NumberOfPeople <= table.NumberOfChairs) && table.IsClean && !table.IsOccupied)
                    {
                        table.IdOfClient = client.Id;
                        table.IsOccupied = true;
                        waitingLine.RemoveClient(client);
                        return;
                    }
                }
            }
        }

        public int CheckTableAvailble(Client client, TablesBook tablesBook)
        {
            foreach (var table in tablesBook.DinnerTables)
            {
                if ((client.NumberOfPeople <= table.NumberOfChairs) && table.IsClean && !table.IsOccupied)
                {
                    table.IdOfClient = client.Id;
                    table.IsOccupied = true;
                    return table.Id;
                }
            }
            return 0;
        }
    }
}
