using SimpleCalc.Answer;

namespace SimpleCalc.Calculations
{
    internal class Addition
    {
        public static void AdditionCalc()
        {
            int first = Addition.AdditionFirst();
            int second = Addition.AdditionSecond();
            Console.WriteLine(Solution.Calcuation() + first + " + " + second + " = " + (first + second));
        }

        public static int AdditionFirst()
        {
            Console.WriteLine("-Please enter the first number for your calculation");
            string? input = Console.ReadLine();
            if (Int32.TryParse(input, out int inputInt))
            { return inputInt; }
            else
            {
                Invalid.InvalidInput();
                Addition.AdditionFirst(); //start again
            }
            return 0;
        }

        public static int AdditionSecond()
        {
            Console.WriteLine("-Please enter the second number for your calculation");
            string? input = Console.ReadLine();
            if (Int32.TryParse(input, out int inputInt))
            { return inputInt; }
            else
            {
                Invalid.InvalidInput();
                Addition.AdditionSecond(); //start again
            }
            return 0;
        }
    }
}
