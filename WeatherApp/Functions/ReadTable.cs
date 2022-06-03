using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace WeatherApp.Functions
{
    internal class ReadTable
    {
        public static IEnumerable<WeatherByDay> ReturnTable(string path)
        {
            Console.WriteLine("-Using " + path);

            string[] lines = File.ReadAllLines(path);   //all lines in table
            bool readingData = false;   //readingData starts off as not reading
            string[] lineParts;  //lineParts = parts/elements that form a line. lineParts[0] = first element in line

            foreach (string line in lines)
            {
                lineParts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //skip read if whitespace
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                //start readingData from Dy
                if (lineParts[0] == "Dy")
                {
                    readingData = true;
                    continue;
                };

                //stop readingData from mo
                if (lineParts[0] == "mo")
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
}