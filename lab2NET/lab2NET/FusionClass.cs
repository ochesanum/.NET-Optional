using System;
using System.Collections.Generic;
using System.IO;

namespace lab2NET
{
    public class FusionClass
    {
        private static string dataType;
        private static string FILE_NAME;
        private static int internalFlag;
        public static void SetFlags(string data)
        {
            dataType = data;
            if (dataType == "weather")
            {
                FILE_NAME = "E:\\uni\\.NET\\.NET-Optional\\lab2NET\\lab2NET\\Weather\\weather.dat";
                internalFlag = 1;
            }
            else if (dataType == "football")
            {
                FILE_NAME = "E:\\uni\\.NET\\.NET-Optional\\lab2NET\\lab2NET\\Football\\football.dat";
                internalFlag = 0;
            }
        }
        public static void GetRequiredData()
        {
            string data = "";
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
                    if (internalFlag == 1)
                    {
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
                                data = list[i][0];
                            }
                        }
                        Console.WriteLine("The day with the smallest temperature spread is: " + data + " with the temp spread of " + minim);
                    }
                    else
                    {
                        for (int i = 1; i < list.Count; i++)
                        {
                            if(!list[i][0].Contains("-"))
                            {
                                int newMin = Math.Abs(Int32.Parse(list[i][6]) - Int32.Parse(list[i][8]));
                                if (newMin < minim)
                                {
                                    minim = newMin;
                                    data = list[i][1];
                                }
                            }
                        }
                        Console.WriteLine("The team with the smallest goal difference " + "(" + minim + ") is " + data);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        
    }
}