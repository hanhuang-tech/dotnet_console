using SimpleCalc.Input;

namespace SimpleCalc
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first number for your calculation");
            string? inputNumOne = Console.ReadLine();
            int inputNumOneInt = PleaseEnter.EnterNumOne(inputNumOne);

            PleaseEnter.EnterSign();
            Console.WriteLine("Please enter an arithmetic operator for your calculation");
            Console.WriteLine("- Enter: + - * / %");
            string opSign = Console.ReadLine();
            string opSignCalc = PleaseEnter.EnterSign(opSign);

            Console.WriteLine("Please enter the second number for your calculation");
            string? inputNumTwo = Console.ReadLine();
            int inputNumTwoInt = PleaseEnter.EnterNumTwo(inputNumTwo);

            Console.WriteLine("Your answer is: " + );
        }

    }
}

