using SimpleCalc.Answer;

namespace SimpleCalc.Calculations
{
    internal class Multiplication
    {
        public static void MultiplicationCalc()
        {
            int first = Multiplication.MultiplicationFirst();
            int second = Multiplication.MultiplicationSecond();
            Console.WriteLine(Solution.Calcuation() + first + " * " + second + " = " + (first * second));
        }

        public static int MultiplicationFirst()
        {
            Console.WriteLine("-Please enter the first number for your calculation");
            string? input = Console.ReadLine();
            if (Int32.TryParse(input, out int inputInt))
            { return inputInt; }
            else
            {
                Invalid.InvalidInput();
                Multiplication.MultiplicationFirst(); //start again
            }
            return 0;
        }

        public static int MultiplicationSecond()
        {
            Console.WriteLine("-Please enter the second number for your calculation");
            string? input = Console.ReadLine();
            if (Int32.TryParse(input, out int inputInt))
            { return inputInt; }
            else
            {
                Invalid.InvalidInput();
                Multiplication.MultiplicationSecond(); //start again
            }
            return 0;
        }
    }
}
