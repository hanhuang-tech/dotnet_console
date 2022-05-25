using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Functions
{
    internal class MinVariTemp
    {
        public static void MinTempCalc(string[][] table)
        {
            Console.WriteLine("< Calculating the day with the minimum variation in temperature >");
            Console.WriteLine(">Looking up weather.txt");

            for (int i = 8; i < table.Length - 1; i++)  //Day 1 is table[8][1]
            {
                if (MinVariDay(table) == i) { Console.BackgroundColor = ConsoleColor.Blue; }  //highlight day of min. variation
                Console.WriteLine("Day " + (i - 7) + "- MxT: " + table[i][1] + ", MnT: " + table[i][2]);
                Console.ResetColor();
            }
            Console.WriteLine("The day with the minimum variation of temperature is on day " + MinVariDay(table));
        }

        public static int MinVariDay(string[][] table)
        {
            float[] tempDiffArr = new float[table.Length];
            int indexMinVari;
            //Console.WriteLine(table.Length - 1);

            //table.Length - 1 to discount index 0, -8 as table values starts at table[8]
            for (int i = 0; i < table.Length - 9; i++)
            {
                float.TryParse(table[i + 8][1], out float x);   //MxT
                float.TryParse(table[i + 8][2], out float y);   //MnT
                tempDiffArr[i] = x - y;
                Console.WriteLine(i + " tempDiffArr[]:" + tempDiffArr[i] + " x:" + x + " y:" + y);
            }

            Console.WriteLine(tempDiffArr.Min());
            indexMinVari = Array.LastIndexOf(tempDiffArr, tempDiffArr.Min());
            return indexMinVari;
        }
    }
}
