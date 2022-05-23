using System;
using System.IO;
using System.Windows.Forms;

namespace WeatherApp.Functions
{
    internal class MinVarTemp
    {
        public static void MinVarTempCalc(string file)
        {
            Console.WriteLine("-Using " + file);
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {
                //var value = line.Split(new string[] { }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(line);
            }
        }
    }
}
