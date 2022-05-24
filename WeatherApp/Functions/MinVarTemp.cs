using System;
using System.IO;
using System.Linq;

namespace WeatherApp.Functions
{
    internal class MinVarTemp
    {
        public static void MinVarTempCalc(string path)
        {
            Console.WriteLine("-Using " + path);

            string[] lines = File.ReadAllLines(path);   //all lines in table
            string[] lcontent; //content on each line
            string[][] arr = new string[lines.Count() + 1][];   //
            int k = 1;

            foreach (string line in lines)
            {
                lcontent = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < lcontent.Length; i++)
                {
                    if (arr[k] == null) { arr[k] = new string[lcontent.Length + 1]; }
                    arr[k][i] = lcontent[i];
                }
                k++;
            }

            Console.WriteLine(arr[10][3]);
        }
    }
}
