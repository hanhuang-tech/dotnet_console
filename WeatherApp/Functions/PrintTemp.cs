using System;
using System.Collections.Generic;

namespace WeatherApp.Functions
{
    internal class Print
    {
        public static void PrintTemp(IEnumerable<WeatherByDay> weatherByDays)
        {
            var (min, max) = WeatherCalc.MinMaxTemp(weatherByDays);

            Console.WriteLine("< Calculating the day with the Minimum and Maximum variation in temperature >");
            Console.WriteLine(">Looking up weather.txt");

            foreach (var day in weatherByDays)
            {
                if (min.Day == day.Day) { Console.BackgroundColor = ConsoleColor.Blue; }  //highlight min. variation
                if (max.Day == day.Day) { Console.BackgroundColor = ConsoleColor.Red; }  //highlight max. variation
                Console.WriteLine("Day " + day.Day + "- MxT: " + day.MaxT + ", MnT: " + day.MinT);
                Console.ResetColor();
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(">The day with the min. variation of temp, occurs on Day " + min.Day);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(">With a variation between MxT and MnT of " + min.DiffT);
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(">The day with the max. variation of temp, occurs on Day " + max.Day);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">With a variation between MxT and MnT of " + max.DiffT);
            Console.ResetColor();
        }
    }
}
