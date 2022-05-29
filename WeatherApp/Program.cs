using System;
using System.IO;
using System.Windows.Forms;
using WeatherApp.Functions;

namespace WeatherApp
{
    internal class Program
    {
        static void Main()
        {
            //locate input file
            string file = Path.Combine(Application.StartupPath, @"..\..\weather.txt");
            Console.WriteLine("- WeatherApp -");
            Console.WriteLine("Please select a calculation you wish to use");
            Console.WriteLine("1) Minimum & Maximum Temp Variation 2) Something else");
            string ynRead = Console.ReadLine();

            //read table, then manipulate this data
            if (ynRead == "1")
            { VariableTemp.PrintVariTemp(ReadTable.ReturnTable(file)); }
            else if (ynRead == "2")
            { Console.WriteLine("Oops, there is nothing here." + Environment.NewLine); Main(); }
            else
            { Console.WriteLine("!Invalid input, please try again" + Environment.NewLine); Main(); }
        }
    }
}

