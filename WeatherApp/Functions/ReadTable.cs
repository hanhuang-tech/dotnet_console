using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WeatherApp.Functions
{
    internal class Read
    {
        public static IEnumerable<WeatherByDay> ReadTable(string path)
        {
            Console.WriteLine("-Using " + path);

            string[] lines = File.ReadAllLines(path);   //all lines in table
            bool readingData = false;   //readingData starts off as not reading
            string[] lineParts;  //lineParts = parts/elements that form a line. lineParts[0] = first element in line

            foreach (string line in lines)
            {
                lineParts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //skip read if whitespace
                if (lineParts.Any() && string.IsNullOrEmpty(line))
                {
                    continue;
                }

                //start readingData from Dy
                if (lineParts.Any() && lineParts[0] == "Dy")
                {
                    readingData = true;
                    continue;
                };

                //stop readingData from mo
                if (lineParts.Any() && lineParts[0] == "mo")
                {
                    readingData = false;
                    yield break;
                };

                if (readingData)
                {
                    yield return new WeatherByDay(lineParts);
                }
            }
        }
    }
    internal class WeatherByDay
    {
        //class to cast strings
        public int Day { get; set; }
        public float MaxT { get; set; }
        public float MinT { get; set; }
        public float DiffT => Math.Abs(MaxT - MinT);    //find diff in absolute value

        public WeatherByDay(string[] lineParts)
        {
            Day = Convert.ToInt32(lineParts[0]);
            MaxT = float.Parse(lineParts[1]);
            MinT = float.Parse(lineParts[2]);
        }
    }
}
