public static class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                line = "3 5 10";

                Input input = new Input(line);
                string[] strArr = input.SplitStr();   //assignment of string array

                Input inputArr = new Input(strArr);
                input.ToInt(strArr);

                Console.WriteLine();

                Console.ReadLine();
            }
    }
}

public class Input
{
    public string strInput;
    public string[] strArray;
    public Input(string aLine)
    {
        strInput = aLine;
    }

    public Input(string[] input)
    {
        strArray = input;
    }
    public string[] SplitStr()
    {
        string[] strSplit = strInput.Split(' ');
        return strSplit;
    }

    public int[] ToInt(string[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            intArray[i] = Convert.ToInt32(input[i]);
        }
        return intArray;
    }
}
//calculation
