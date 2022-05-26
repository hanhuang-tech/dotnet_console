using System;
using System.Linq;

namespace WeatherApp.Functions
{
    internal class MinVariTemp
    {
        public static void PrintTable(string[][] table)
        {
            //minTempArr[0]: Index of minimum temp variation. minTempArr[1]: Minimum variation in temp as an int
            int[] minTempArr = GetMinTemp(table);
            int minVariDay = minTempArr[0] + 1;   //+1 for Day as Array.IndexOf(tempDiff, tempDiff.Min()) starts at [0] 
            int getTableValue = minTempArr[0] + 8; //Index of minimum temp variation starts at 0. Day 1 starts row 8

            Console.WriteLine("< Calculating the day with the minimum variation in temperature >");
            Console.WriteLine(">Looking up weather.txt");

            for (int i = 8; i < table.Length - 1; i++)  //Day 1 is table[8][1]
            {
                if (getTableValue == i) { Console.BackgroundColor = ConsoleColor.Blue; }  //highlight day of min. variation
                Console.WriteLine("Day " + (i - 7) + "- MxT: " + table[i][1] + ", MnT: " + table[i][2]);
                Console.ResetColor();
            }
            Console.WriteLine(">The day with the minimum variation of temperature between MxT and MnT, occurs on Day " + minVariDay);
            Console.WriteLine(">With a temperature variation of " + minTempArr[1]);
        }

        public static int[] GetMinTemp(string[][] table)
        {
            float[] tempDiff = new float[table.Count()];

            //MinTempVari[0]: Index of minimum temp variation. MinTempVari[1]: Minimum variation in temp as an int
            int[] minTempVari = new int[2];

            //table.Length - 1 to discount index 0, -8 as table values starts at table[8]
            for (int i = 0; i < table.Length - 9; i++)  //i = 0, i < 30
            {
                float.TryParse(table[i + 8][1], out float x);   //MxT. Table of values start at table[8][0]
                float.TryParse(table[i + 8][2], out float y);   //MnT.
                tempDiff[i] = x - y;
            }
            Array.Resize(ref tempDiff, tempDiff.Length - 9);    //Resize array to take out empty arrays defaulted 0
            minTempVari[0] = Array.IndexOf(tempDiff, tempDiff.Min());
            minTempVari[1] = (int)tempDiff.Min();
            return minTempVari; //returns index for min of array, +1 as day 1 starts at [0]
        }
    }
}
