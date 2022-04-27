using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator.Models
{
    sealed class Restaurant
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<Worker> Workers { get; private set; } = new List<Worker>();
        public List<Table> Tables { get; private set; } = new List<Table>();

        public Restaurant(string name, string description)
        {
            Name = name;
            Description = description;
        }

        int GetNumberOfWorkers()
        {
            return Workers.Count;
        }

        void AddWorker(Worker worker)
        {
            Workers.Add(worker);
        }

        void RemoveWorker(Worker worker)
        {
            Workers.Remove(worker);

        }

    }
}
