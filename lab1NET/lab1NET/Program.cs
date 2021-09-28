using System;

namespace lab1NET
{
    public abstract class Employee
    {
        public abstract String Salutations();
    }
    public class Manager : Employee
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
            return firstname + " " + lastname;
        }

        public String IsActive()
        {
            if ((EndDate.Ticks - StartDate.Ticks) < 0)
                return "Inactive";

            return "Active";

        }

        public override String Salutations()
        {
            return "Hello Manager";
        }
        
    }

    public class Arhitect : Employee
    {
        private long id;
        private String firstname;
        private String lastname;
        private DateTime StartDate;
        private DateTime EndDate;
        private int salary;

        public Arhitect()
        {
        }

        public Arhitect(long id, string firstname, string lastname, DateTime startDate, DateTime endDate, int salary)
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
            return firstname + " " + lastname;
        }

        public String IsActive()
        {
            if ((EndDate.Ticks - StartDate.Ticks) < 0)
                return "Not Active";

            return "Active";

        }
        public override String Salutations()
        {
            return "Hello Arhitect";
        }
    }

    public static class ExtensionExample
    {
        public static void ComputeSentece(String str)
        {
            string[] words = str.Split(" ");
            foreach (var word in words)
                Console.WriteLine(word);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Manager m = new Manager(1, "John", "Silver", new System.DateTime(2010,01,01), new System.DateTime(2020,12,31), 3000);
            Console.WriteLine(m.GetFullName()+" " + m.IsActive());
            Arhitect a = new Arhitect();
            Console.WriteLine(m.Salutations()+ " " + a.Salutations());
            ExtensionExample.ComputeSentece("The quick brown fox jumps over the lazy dog.");
        }
    }
}