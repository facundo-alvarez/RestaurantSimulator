using RestaurantSimulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RestaurantSimulator
{
    public partial class MainWindow : Window
    {
        Restaurant restaurant = new Restaurant("Giorgios","Italian Pizzeria");
        
        Worker workerOne = new Chef(0001, "John Doe", new DateOnly(1992, 11, 7), new DateOnly(2022, 4, 25), 60000, 8);
        Worker workerTwo = new DishWasher(0002, "Martin Garcia", new DateOnly(1997, 12, 5), new DateOnly(2022, 4, 25), 15000, 8);
        Worker workerThree = new Cleaner(0003, "Manuel Perez", new DateOnly(1995, 6, 13), new DateOnly(2022, 4, 25), 20000, 8);
        Worker workerFour = new Server(0004, "Florencia Alvarez", new DateOnly(1987, 12, 5), new DateOnly(2022, 4, 25), 30000, 8);
        Worker workerFive = new Server(0005, "Agustin Di Marco", new DateOnly(1991, 2, 23), new DateOnly(2022, 4, 25), 30000, 8);
        Worker workerSix = new Bartender(0006, "Franc Harrison", new DateOnly(1978, 8, 30), new DateOnly(2022, 4, 25), 40000, 8);
        Worker workerSeven = new Accountant(0007, "Marc Antoni", new DateOnly(1958, 2, 1), new DateOnly(2022, 4, 25), 60000, 8);
        Worker workerEight = new CookAssistant(0008, "Pedro Poi", new DateOnly(1998, 3, 10), new DateOnly(2022, 4, 25), 20000, 8);
        Worker workerNine = new Receptionist(0009, "Sofia Herrera", new DateOnly(1997, 12, 20), new DateOnly(2022, 4, 25), 35000, 8);

        Models.Table tableOne = new Models.Table();
        Models.Table tableTwo = new Models.Table();
        Models.Table tableThree = new Models.Table();
        Models.Table tableFour = new Models.Table();




        public MainWindow()
        {
            InitializeComponent();
            restaurant.Workers.Add(workerOne);
            restaurant.Workers.Add(workerTwo);
            restaurant.Workers.Add(workerThree);
            restaurant.Workers.Add(workerFour);
            restaurant.Workers.Add(workerFive);
            restaurant.Workers.Add(workerSix);
            restaurant.Workers.Add(workerSeven);
            restaurant.Workers.Add(workerEight);
            restaurant.Workers.Add(workerNine);

            restaurant.Tables.Add(tableOne);
            restaurant.Tables.Add(tableTwo);
            restaurant.Tables.Add(tableThree);
            restaurant.Tables.Add(tableFour);
        }

   
    }
}
