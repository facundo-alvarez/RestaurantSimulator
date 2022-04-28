namespace RestaurantSimulator.DOMAIN.Models
{
    public class Restaurant
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<Worker> Workers { get; private set; } = new List<Worker>();       

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
