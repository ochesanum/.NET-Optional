using System;

namespace lab1NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Manager m = new Manager(1, "John", "Silver", new System.DateTime(2010,01,01), new System.DateTime(2020,12,31), 3000);
            Console.WriteLine(m.GetFullName()+" " + m.IsActive());
            Arhitect a = new Arhitect(2, "Alex", "Silver", new System.DateTime(2010,01,01), new System.DateTime(2022,12,31), 4000);
            Console.WriteLine(a.GetFullName() +" " + a.IsActive());
            Console.WriteLine(m.Salutations()+ "\n" + a.Salutations());
            ExtensionExample.ComputeSentece("The quick brown fox jumps over the lazy dog.");
            
        }
    }
}