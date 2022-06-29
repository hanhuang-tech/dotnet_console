using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                line = "hello";
                Input input = new Input(line);
                char[] cArray = input.ToArray();
                Array.Sort(cArray); //alphabetically sort char array

                Output chars = new Output(cArray);
                IEnumerable<char> uniqueChars = chars.UniqueChars();

                Output count = new Output(uniqueChars);
                IEnumerable<int> charCount = count.CountChars(cArray);

                foreach (var item in charCount) { Console.WriteLine(item); }
                Console.ReadLine();
            }
    }
}

public class Input
{
    public string inputStr;
    public Input(string aInputStr)
    {
        inputStr = aInputStr;
    }
    public char[] ToArray()
    {
        char[] charArr = inputStr.ToCharArray();
        return charArr;
    }
}

public class Output
{
    public char[] charArray;
    IEnumerable<char> uniqueChars;

    public Output(char[] aCharArray)
    {
        charArray = aCharArray;
    }
    public Output(IEnumerable<char> eUniqueChars)
    {
        uniqueChars = eUniqueChars;
    }
    public IEnumerable<char> UniqueChars()
    {
        IEnumerable<char> uniqueChars = charArray.Distinct();
        return uniqueChars;
    }

    public IEnumerable<int> CountChars(char[] cArray)
    {
        int charCount = 0;
        for (int i = 0; i < cArray.Length; i++)
        {
            if (charCount <= 1)
            {
                charCount = cArray.Count(c => c == cArray[i]);
                yield return charCount;
            }
            Console.WriteLine("i= " + i);
        }
    }
}