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
        }
        
    }
}
