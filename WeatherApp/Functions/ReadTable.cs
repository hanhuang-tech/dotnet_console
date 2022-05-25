using System;
using System.IO;
using System.Linq;

namespace WeatherApp.Functions
{
    internal class ReadTable
    {
        public static string[][] ReturnTable(string path)
        {
            Console.WriteLine("-Using " + path);

            string[] lines = File.ReadAllLines(path);   //all lines in table
            string[] lvalues; //values that form a line
            string[][] table = new string[lines.Length][]; //2d array
            int x = 0;  //x-axis

            foreach (string line in lines)
            {
                //ignore empty entries, insert each value from line to form lines
                lvalues = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int y = 0; y < lvalues.Length; y++)    //for every y-axis
                {
                    if (table[x] == null)
                    { table[x] = new string[lvalues.Count()]; }   //x-axis of table based on no of values on lines
                    table[x][y] = lvalues[y];
                }
                x++;
            }
            return table;
        }
    }
}