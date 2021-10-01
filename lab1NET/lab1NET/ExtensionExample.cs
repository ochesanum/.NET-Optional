using System;
namespace lab1NET
{
    public static class ExtensionExample  
    {
        public static void ComputeSentece(String str) //metoda identifica numarul de cuvinte din propozitia data ca parametru
        {
            string[] words = str.Split(" ");
            Console.WriteLine(words.Length);
        }
    }
}