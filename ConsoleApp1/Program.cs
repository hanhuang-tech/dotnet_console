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
                Print.PrintNumbers(Read.ReadNumbers(line));
            }
    }
}
internal class Read
{
    public static IEnumerable<LineToInt> ReadNumbers(string line)
    {
        string[] lineItem;

        foreach (char item in line)
        {
            lineItem = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            yield return new LineToInt(lineItem);
        }
    }
}

internal class LineToInt
{
    public LineToInt(string[] line)
    {
        ToInt = Convert.ToInt32(line);
    }
    public int ToInt { get; set; }
}

internal class Print
{
    public static void PrintNumbers(LineToInt line)
    {
        var a = line.ToInt;
        Console.WriteLine(a);
    }
}


