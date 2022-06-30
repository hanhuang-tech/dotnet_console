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

                ToCount input = new ToCount(line);
                IEnumerable<char> eNum = input.ToEnum().OrderBy(g => g); //alphabetically sort char enum
                IEnumerable<char> uniqueChars = input.UniqueChars(eNum);
                int uniqueCharsLength = uniqueChars.Count();

                ToCount count = new ToCount();
                IEnumerable<int> charCount = count.CountChars(eNum);

                ToCount output = new ToCount();
                string myOutput = output.ConcatChars(uniqueChars, charCount, uniqueCharsLength);

                Console.WriteLine(myOutput);

                Console.ReadLine();
            }
    }
}

public class ToCount
{
    public string inputStr;
    public ToCount() { }
    public ToCount(string aInputStr)
    {
        inputStr = aInputStr;
    }

    public IEnumerable<char> UniqueChars(IEnumerable<char> eNumChar)
    {
        IEnumerable<char> eDistinct = eNumChar.Distinct();
        return eDistinct;
    }

    public IEnumerable<char> ToEnum()
    {
        char[] charArray = inputStr.ToCharArray();  //Convert string into char array, then to IEnumerable
        char eChar;

        foreach (var item in charArray)
        {
            eChar = item;
            yield return eChar;
        }
    }

    public IEnumerable<int> CountChars(IEnumerable<char> iEChar)
    {
        int index = 0;
        int charCount = 0;
        do
        {
            //if count of letter is equals or more than 2, reset count to 0
            //only start counting if charCount is not 2 or more
            if (charCount >= 2) { charCount = 0; }
            else
            {
                charCount = iEChar.Count(c => c == iEChar.ElementAt(index));
                yield return charCount;
            }
            index++;
        } while (index < iEChar.Count());
    }

    public string ConcatChars(IEnumerable<char> chars, IEnumerable<int> ints, int aUniqueCharsLength)
    {
        string output = "";
        for (int i = 0; i < aUniqueCharsLength; i++)
        {
            output = output + chars.ElementAt(i) + ints.ElementAt(i);
        }
        return output;
    }
}