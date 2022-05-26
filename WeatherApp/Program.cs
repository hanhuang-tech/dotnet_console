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
            Console.WriteLine("Please select a function you wish to action");
            Console.WriteLine("1) MinVarTempCalc 2) Something else");
            string ynRead = Console.ReadLine();
            if (ynRead == "1")
            { MinVariTemp.PrintTable(ReadTable.ReturnTable(file)); }   //Read table, then manipulate data in table
            else if (ynRead == "2")
            { Console.WriteLine("Oops, there is nothing here." + Environment.NewLine); Main(); }
            else
            { Console.WriteLine("!Invalid input, please try again" + Environment.NewLine); Main(); }
        }
    }
}

