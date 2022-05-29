using System;
using System.Linq;

namespace WeatherApp.Functions
{
    internal class VariableTemp
    {
        public static void PrintVariTemp(string[][] table)
        {
            //TempArr[0]: Index of minimum temp variation
            //TempArr[1]: Minimum variation in temp as an int
            //TempArr[2]: Index of maximum temp variation
            //TempArr[3]: Maximum variation in temp as an int
            int[] TempArr = GetVariTemp(table);
            int minVariDay = TempArr[0] + 1;   //Index as day with min. variation. Add 1 to account starting at [0] index
            int minVariValue = TempArr[0] + 8; //Index as minimum temp variation. Day 1 starts at row 8 of table
            int maxVariDay = TempArr[2] + 1;   //Index for Day with max. variation. Add 1 to account starting at [0] index 
            int maxVariValue = TempArr[2] + 8; //Index as maximum temp variation. Day 1 starts at row 8 of table

            Console.WriteLine("< Calculating the day with the Minimum and Maximum variation in temperature >");
            Console.WriteLine(">Looking up weather.txt");

            for (int i = 8; i < table.Length - 1; i++)  //i = Day. Day 1 starts at i = 8, row 8 of table
            {
                if (minVariValue == i) { Console.BackgroundColor = ConsoleColor.Blue; }  //highlight min. variation
                if (maxVariValue == i) { Console.BackgroundColor = ConsoleColor.Red; }  //highlight max. variation
                Console.WriteLine("Day " + (i - 7) + "- MxT: " + table[i][1] + ", MnT: " + table[i][2]);
                Console.ResetColor();
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(">The day with the min. variation of temp, occurs on Day " + minVariDay);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(">With a variation between MxT and MnT of " + TempArr[1]);
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(">The day with the max. variation of temp, occurs on Day " + maxVariDay);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">With a variation between MxT and MnT of " + TempArr[3]);
            Console.ResetColor();
        }

        public static int[] GetVariTemp(string[][] table)
        {
            float[] tempDiff = new float[table.Count()];
            int[] TempVari = new int[4];

            //table.Length - 1 to discount index 0 for being day 1, and -8 as table values starts at table[8]
            for (int i = 0; i < table.Length - 9; i++)  //i = 0, i < 30
            {
                float.TryParse(table[i + 8][1], out float x);   //MxT. Table of values start at table[8][0]
                float.TryParse(table[i + 8][2], out float y);   //MnT.
                tempDiff[i] = x - y;
            }
            Array.Resize(ref tempDiff, tempDiff.Length - 9);    //Resize array to take out empty arrays defaulted 0
            TempVari[0] = Array.IndexOf(tempDiff, tempDiff.Min());
            TempVari[1] = (int)tempDiff.Min();
            TempVari[2] = Array.IndexOf(tempDiff, tempDiff.Max());
            TempVari[3] = (int)tempDiff.Max();
            return TempVari; //returns temp variation in an array
        }
    }
}
