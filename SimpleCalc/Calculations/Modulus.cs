using SimpleCalc.Answer;

namespace SimpleCalc.Calculations
{
    internal class Modulus
    {
        public static void ModulusCalc()
        {
            int first = ModulusFirst();
            int second = ModulusSecond();
            Console.WriteLine(Solution.Calcuation() + first + " % " + second + " = " + (first % second));
        }

        public static int ModulusFirst()
        {
            Console.WriteLine("-Please enter the first number for your calculation");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int inputInt))
            { return inputInt; }
            else
            {
                Invalid.InvalidInput();
                Modulus.ModulusFirst(); //start again
            }
            return 0;
        }

        public static int ModulusSecond()
        {
            Console.WriteLine("-Please enter the second number for your calculation");
            string? input = Console.ReadLine();
            if (Int32.TryParse(input, out int inputInt))
            { return inputInt; }
            else
            {
                Invalid.InvalidInput();
                Modulus.ModulusSecond(); //start again
            }
            return 0;
        }
    }
}
