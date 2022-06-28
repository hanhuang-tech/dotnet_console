using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public static class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
    }
}
