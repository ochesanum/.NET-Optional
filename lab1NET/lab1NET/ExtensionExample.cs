using System;
namespace lab1NET
{
    public static class ExtensionExample
    {
        public static void ComputeSentece(String str)
        {
            string[] words = str.Split(" ");
            // foreach (var word in words)
            //     Console.WriteLine(word);
            Console.WriteLine(words.Length);
        }
    }
}