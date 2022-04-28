using RestaurantSimulator.DOMAIN.Models;
using System;

namespace RestaurantSimulator.APP
{
    public class Program
    {
        public static void Main()
        {
            Restaurant restaurant = new Restaurant("Giorgios", "Italian Pizzeria");
            TablesBook tablesBook = new TablesBook();

            Worker workerOne = new Chef(01, "John Doe", new DateOnly(1992, 11, 7), new DateOnly(2022, 4, 25), 60000, 8);
            Worker workerTwo = new DishWasher(02, "Martin Garcia", new DateOnly(1997, 12, 5), new DateOnly(2022, 4, 25), 15000, 8);
            Worker workerThree = new Receptionist(03, "Sofia Herrera", new DateOnly(1997, 12, 20), new DateOnly(2022, 4, 25), 35000, 8);
            Worker workerFour = new Server(04, "Florencia Alvarez", new DateOnly(1987, 12, 5), new DateOnly(2022, 4, 25), 30000, 8);
            Worker workerFive = new CookAssistant(05, "Pedro Poi", new DateOnly(1998, 3, 10), new DateOnly(2022, 4, 25), 20000, 8);

            DinnerTable tableOne = new DinnerTable(2);
            DinnerTable tableTwo = new DinnerTable(2);
            DinnerTable tableThree = new DinnerTable(4);
            DinnerTable tableFour = new DinnerTable(4);

            restaurant.Workers.Add(workerOne);
            restaurant.Workers.Add(workerTwo);
            restaurant.Workers.Add(workerThree);
            restaurant.Workers.Add(workerFour);
            restaurant.Workers.Add(workerFive);

            tablesBook.DinnerTables.Add(tableOne);
            tablesBook.DinnerTables.Add(tableTwo);
            tablesBook.DinnerTables.Add(tableThree);
            tablesBook.DinnerTables.Add(tableFour);

        }
    }
}