using System;
using System.Collections.Generic;
using System.IO;

namespace lab2NET.Football
{
    public class FootballData
    {
        private const string FILE_NAME = "E:\\uni\\.NET\\.NET-Optional\\lab2NET\\lab2NET\\Football\\football.dat";
        
        public static void GetSmallestGoalDifference()
        {
            string team = "";
            int minim = Int32.MaxValue;
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(FILE_NAME))
                {
                    // Read the stream as a string, and write the string to the console.
                    var list = new List<string[]>();
                    string line;
                    while((line = sr.ReadLine()) != null)  
                    {  
                        string [] split = line.Split((char[])null,StringSplitOptions.RemoveEmptyEntries);
                        list.Add(split);
                    }  
                    
                    for (int i = 1; i < list.Count; i++)
                    {
                        if(!list[i][0].Contains("-"))
                        {
                            int newMin = Math.Abs(Int32.Parse(list[i][6]) - Int32.Parse(list[i][8]));
                            if (newMin < minim)
                            {
                                minim = newMin;
                                team = list[i][1];
                            }
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("The team with the smallest goal difference " + "(" + minim + ") is " + team);
        }
    }
}