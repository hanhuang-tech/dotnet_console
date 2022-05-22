using SimpleCalc.Answer;

namespace SimpleCalc.Calculations
{
    internal class Division
    {
        public static void DivisionCalc()
        {
            float first = DivisionFirst();
            float second = DivisionSecond();
            Console.WriteLine(Solution.Calcuation() + first + " / " + second + " = " + (first / second));
        }

        public static int DivisionFirst()
        {
            Console.WriteLine("-Please enter the first number for your calculation");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int inputInt))
            { return inputInt; }
            else
            {
                Invalid.InvalidInput();
                DivisionFirst(); //start again
            }
            return 0;
        }

        public static int DivisionSecond()
        {
            Console.WriteLine("-Please enter the second number for your calculation");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int inputInt))
            { return inputInt; }
            else
            {
                Invalid.InvalidInput();
                DivisionSecond(); //start again
            }
            return 0;
        }
    }
}
