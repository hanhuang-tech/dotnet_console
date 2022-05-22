using SimpleCalc.Answer;

namespace SimpleCalc.Calculations
{
    internal class Subtraction
    {
        public static void SubtractionCalc()
        {
            int first = Subtraction.SubtractionFirst();
            int second = Subtraction.SubtractionSecond();
            Console.WriteLine(Solution.Calcuation() + first + " - " + second + " = " + (first - second));
        }

        public static int SubtractionFirst()
        {
            Console.WriteLine("-Please enter the first number for your calculation");
            string? input = Console.ReadLine();
            if (Int32.TryParse(input, out int inputInt))
            { return inputInt; }
            else
            {
                Invalid.InvalidInput();
                Subtraction.SubtractionFirst(); //start again
            }
            return 0;
        }

        public static int SubtractionSecond()
        {
            Console.WriteLine("-Please enter the second number for your calculation");
            string? input = Console.ReadLine();
            if (Int32.TryParse(input, out int inputInt))
            { return inputInt; }
            else
            {
                Invalid.InvalidInput();
                Subtraction.SubtractionSecond(); //start again
            }
            return 0;
        }
    }
}
