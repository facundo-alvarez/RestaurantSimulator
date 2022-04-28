namespace RestaurantSimulator.DOMAIN.Models
{
    public abstract class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateOnly HiredDate { get; set; }
        public int Salary { get; set; }
        public int WorkHours { get; set; }

        public Worker(int id, string name, DateOnly birthDate, DateOnly hiredDate, int salary, int workHours)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            HiredDate = hiredDate;
            Salary = salary;
            WorkHours = workHours;
        }
    }
}
