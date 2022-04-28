using RestaurantSimulator.DOMAIN.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantSimulator.APP
{
    public class Program
    {
        public static async Task Main()
        {
            #region Data

            var restaurant = new Restaurant("Giorgios", "Italian Pizzeria");
            var tablesBook = new TablesBook();
            var waitingLine = new WaitingLine();

            var tableOne = new DinnerTable(1, 2);
            var tableTwo = new DinnerTable(2, 2);
            var tableThree = new DinnerTable(3, 3);
            var tableFour = new DinnerTable(4, 4);

            var foodMenu1 = new Food("Hamburger Mini", 13.99m);
            var foodMenu2 = new Food("Hamburger Medium", 16.99m);
            var foodMenu3 = new Food("Hamburger Large", 19.99m);

            int orderCounter = 0;
            int table = 0;

            var menu = new Menu();
            menu.FoodMenu.Add(foodMenu1);
            menu.FoodMenu.Add(foodMenu2);
            menu.FoodMenu.Add(foodMenu3);


            var chef = new Chef(01, "John Doe", new DateOnly(1992, 11, 7), new DateOnly(2022, 4, 25), 60000, 8);
            var dishWasher = new DishWasher(02, "Martin Garcia", new DateOnly(1997, 12, 5), new DateOnly(2022, 4, 25), 15000, 8);
            var receptionist = new Receptionist(03, "Sofia Herrera", new DateOnly(1997, 12, 20), new DateOnly(2022, 4, 25), 35000, 8);
            var server = new Server(04, "Florencia Alvarez", new DateOnly(1987, 12, 5), new DateOnly(2022, 4, 25), 30000, 8);
            var cook = new CookAssistant(05, "Pedro Poi", new DateOnly(1998, 3, 10), new DateOnly(2022, 4, 25), 20000, 8);

            var clients1 = new Client(1, 2);
            var clients2 = new Client(2, 3);

            var clientMe = new Client(10, 2);

            waitingLine.ClientsWaiting.Add(clients1);
            waitingLine.ClientsWaiting.Add(clients2);

            restaurant.Workers.Add(chef);
            restaurant.Workers.Add(dishWasher);
            restaurant.Workers.Add(receptionist);
            restaurant.Workers.Add(server);
            restaurant.Workers.Add(cook);

            tablesBook.DinnerTables.Add(tableOne);
            tablesBook.DinnerTables.Add(tableTwo);
            tablesBook.DinnerTables.Add(tableThree);
            tablesBook.DinnerTables.Add(tableFour);

            chef.FoodPrepared += cook.OnFoodPreparation;

            #endregion

            Console.WriteLine("Restaurant Simulator");
            Console.WriteLine("Press a key to start..");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("You are waiting on the line...");

            TableAssign(tablesBook, waitingLine, receptionist);


            // Waiting for a table
            int tableCue = 1;
            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("a) Waiting line number");
                Console.WriteLine("b) Leave");

                var key = Console.ReadKey();


                if (key.Key == ConsoleKey.A)
                {
                    Console.Clear();
                    tableCue = waitingLine.CountClientsWaiting();
                    Console.WriteLine($"Clients in the line: {tableCue}");
                }
                else if (key.Key == ConsoleKey.B)
                    goto Exit;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Not an option");
                }
            }
            while (tableCue != 0);


            //Asking for a table
            bool tableReady = false;
            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("a) Asking for a table");
                Console.WriteLine("b) Leave");

                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.A)
                {
                    Console.Clear();
                    table = receptionist.CheckTableAvailble(clientMe,tablesBook);

                    if (table != 0)
                    {
                        tableReady = true;
                        Console.WriteLine($"You have table number: {table}");
                    }
                    else
                        Console.WriteLine("No available tables yet!");
                }
                else if (key.Key == ConsoleKey.B)
                    goto Exit;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Not an option");
                }
            }
            while (!tableReady);


            //Ordering food
            Console.WriteLine("You are going to the table");
            Console.WriteLine("You seated in the table and start reading the menue\n");
            Console.WriteLine("--------------------------------");
            foreach (var foodItem in menu.FoodMenu)
            {
                Console.WriteLine($"Item: {foodItem.Name}  Price: {foodItem.Price}");
            }
            Console.WriteLine("--------------------------------\n");


            bool validOption = false;
            ConsoleKeyInfo key2;
            do
            {    
                Console.WriteLine("Select an option:");
                Console.WriteLine("a) Order food");
                Console.WriteLine("b) Leave");

                key2 = Console.ReadKey();

                if (key2.Key == ConsoleKey.A)
                    validOption = true;
                else if (key2.Key == ConsoleKey.B)
                    validOption = true;
                else
                {
                    Console.Clear();
                    validOption = false;              
                }
            }
            while (!validOption);

            if (key2.Key == ConsoleKey.A)
            {
                Console.Clear();
                bool optionOk = false;
                do
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("a) Menu 1");
                    Console.WriteLine("b) Menu 2");
                    Console.WriteLine("c) Menu 3");

                    var menuOption = Console.ReadKey();
                    Food foodChoosed;

                    if (menuOption.Key == ConsoleKey.A)
                    {
                        optionOk = true;
                        foodChoosed = clientMe.Order(menu, 0);
                        Console.Clear();
                        Console.WriteLine($"Perfect! I will order {foodChoosed.Name} to the kitchen!");
                        await Task.Delay(2000);
                        Console.Clear();

                        chef.CookFood(new Order(orderCounter, foodChoosed, table));
                    }
                    else if (menuOption.Key == ConsoleKey.B)
                    {
                        optionOk = true;
                        foodChoosed = clientMe.Order(menu, 1);
                        Console.Clear();
                        Console.WriteLine($"Perfect! I will order {foodChoosed.Name} to the kitchen!");
                        await Task.Delay(2000);
                        Console.Clear();
                        orderCounter++;
                        chef.CookFood(new Order(orderCounter, foodChoosed, table));
                    }
                    else if (menuOption.Key == ConsoleKey.C)
                    {
                        optionOk = true;
                        foodChoosed = clientMe.Order(menu, 2);
                        Console.Clear();
                        Console.WriteLine($"Perfect! I will order {foodChoosed.Name} to the kitchen!");
                        await Task.Delay(2000);
                        Console.Clear();
                        chef.CookFood(new Order(orderCounter, foodChoosed, table));
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Not a valid option");
                    }

                }
                while (!optionOk);
            }
            else if (key2.Key == ConsoleKey.B)
                goto Exit;


            //Waiting for food
            
            bool served = false;
            do
            {
                Console.WriteLine("Waiting for the food...");
                Console.WriteLine("Select an option:");
                Console.WriteLine("a) Ask for the food");
                Console.WriteLine("b) Leave");

                var menuOption = Console.ReadKey();

                if (menuOption.Key == ConsoleKey.A)
                {
                    bool IsReady = server.CheckOrder(table);
                    if (IsReady)
                    {
                        
                        server.ServePlate(table);
                        served = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Plate is not ready yet...");
                    }
                }
                else if (menuOption.Key == ConsoleKey.B)
                {
                    goto Exit;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Not a valid option");
                }

            }
            while(!served);

            






            Console.ReadKey();
        Exit:
            Console.Clear();
            Console.WriteLine("Good bye!");
            await Task.Delay(1000);
        }

        private static async Task TableAssign(TablesBook tablesBook, WaitingLine waitingLine, Receptionist receptionist)
        {
            while (!waitingLine.ClientsWaiting.Count.Equals(0))
            {
                receptionist.AssignTable(waitingLine, tablesBook);
                await Task.Delay(500);
            }                
        }
    }
}