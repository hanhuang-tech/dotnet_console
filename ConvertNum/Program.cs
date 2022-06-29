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

                Input input = new Input(line);
                int[] intArr = input.ToIntArr();

                IntMax intMax = new IntMax(intArr);
                int maxNum = intMax.FindMax();

                Output output = new Output(intArr, maxNum);
                string[] outputArray = output.OutputArr();
                string outputLine = output.ToOutput(outputArray);

                Console.WriteLine(outputLine);

                Console.ReadLine();
            }
    }
}

public class Input
{
    public string strInput;

    public Input(string aLine)
    {
        strInput = aLine;
    }

    public int[] ToIntArr()
    {
        int[] intSplit = strInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        return intSplit;
    }
}

public class IntMax
{
    public int[] intArray;
    public IntMax(int[] aIntArray)
    {
        intArray = aIntArray;
    }

    public int FindMax()
    {
        return intArray.Max();
    }
}

public class Output
{
    public int[] intArr;
    public int maxNum;
    public Output(int[] aIntArr, int aMaxNum)
    {
        intArr = aIntArr;
        maxNum = aMaxNum;
    }

    public string[] OutputArr()
    {
        string[] strArr = new string[maxNum];
        int index = 0;
        int output = 0;
        do
        {
            output++;   //output starts at 1
            if (output % intArr[0] == 0)
            {
                strArr[index] = "F";
                if (output % intArr[1] == 0)
                {
                    strArr[index] += "B";
                }
            }
            else if (output % intArr[1] == 0)
            {
                strArr[index] = "B";
            }
            else
            {
                strArr[index] = output.ToString();
            }
            index++;
        } while (index < maxNum);

        return strArr;
    }

    //string together items from space delimited string array
    public string ToOutput(string[] aOutputArray)
    {
        return string.Join(" ", aOutputArray);
    }
}
