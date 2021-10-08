using System;
using lab2NET.Football;
using lab2NET.Weather;

namespace lab2NET
{
    class Program
    {
        static void Main(string[] args)
        {
            // WeatherData.GetSmallestTempSpread();
            // FootballData.GetSmallestGoalDifference();
            FusionClass.SetFlags("weather");
            FusionClass.GetRequiredData();
            FusionClass.SetFlags("football");
            FusionClass.GetRequiredData();
            
            /*Kata Questions
             * 1. The decision to read the file and create a list of string arrays of each line allowed us to use
             * the same portion of code when we combined the two classes. However, because the two files aren't parsed
             * the same way we had to repeat the for-loop section, starting from different lines and checking for
             * different characters that needed to be removed (*,-).
             * 
             * 2. Yes, the second class was written almost the same as the first one, just by changing some names and
             * characters as the parsing of the files was similar.
             * 
             * 3. Factoring out common code is a good practice, because it respects the DRY principle. The readability
             * of the program didn't suffer, however, the maintainability has suffered, since we will need to add new
             * flags for other files we will want to parse in the future.
             */
        }
        
    }
}
