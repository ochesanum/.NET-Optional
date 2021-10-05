using System;
using System.Collections.Generic;
using System.IO;

namespace lab2NET.Weather
{
    public class WeatherData
    {
        private const string FILE_NAME = "C:\\Users\\mihoc\\RiderProjects\\lab2NET\\lab2NET\\Weather\\weather.dat";
        public static void GetSmallestTempSpread()
        {
            string day ="";
            int minim = Int32.MaxValue;
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(FILE_NAME))
                {
                    // Read the stream as a string, and write the string to the console.
                    // Console.WriteLine(sr.ReadToEnd());
                    var list = new List<string[]>();
                    string line;
                    while((line = sr.ReadLine()) != null)  
                    {  
                        string [] split = line.Split((char[])null,StringSplitOptions.RemoveEmptyEntries);
                        list.Add(split);
                    }  
                    // for(int i=0;i<list.Count;i++){
                    //     for (int j = 0; j < list[i].Length; j++)
                    //         Console.Write(list[i][j] + " ");
                    //     Console.WriteLine();
                    // }
                    for (int i = 2; i < list.Count-1; i++)
                    {
                        if (list[i][1].Contains("*"))
                            list[i][1] = list[i][1].Trim(new char[] {'*'});
                        if (list[i][2].Contains("*"))
                            list[i][2] = list[i][2].Trim(new char[] {'*'});
                        
                        int newMin = Int32.Parse(list[i][1]) - Int32.Parse(list[i][2]);
                        if (newMin < minim)
                        {
                            minim = newMin;
                            day = list[i][0];
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("The day with the smallest temperature spread is: " + day + " with the temp spread of " + minim);
        }
    }
}