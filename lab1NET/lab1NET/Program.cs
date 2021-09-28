using System;

namespace lab1NET
{
    class Manager
    {
        private long id;
        private String firstname;
        private String lastname;
        private DateTime StartDate;
        private DateTime EndDate;
        private int salary;

        public Manager()
        {
        }

        public Manager(long id, string firstname, string lastname, DateTime startDate, DateTime endDate, int salary)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            StartDate = startDate;
            EndDate = endDate;
            this.salary = salary;
        }

        public String GetFullName()
        {
            return firstname + lastname;
        }

        public double IsActive()
        {
            if ((EndDate.Ticks - StartDate.Ticks) < 0)
                return DateTime.MinValue.Ticks;

            return (EndDate - StartDate).TotalDays;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Manager m = new Manager(1, "Firstname", "Lastname", new System.DateTime(2010,01,01), new System.DateTime(2020,12,31), 3000);
            Console.WriteLine(m.GetFullName()+" " + m.IsActive());
        }
    }
}