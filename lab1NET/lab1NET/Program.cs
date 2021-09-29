using System;

namespace lab1NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Manager m = new Manager(1, "John", "Silver", new System.DateTime(2010,01,01), new System.DateTime(2020,12,31), 3000);
            Console.WriteLine(m.GetFullName()+" " + m.IsActive()+'\n');
            Arhitect a = new Arhitect();
            Console.WriteLine(m.Salutations()+ " " + a.Salutations());
            ExtensionExample.ComputeSentece("The quick brown fox jumps over the lazy dog.");
            
        }
    }
}