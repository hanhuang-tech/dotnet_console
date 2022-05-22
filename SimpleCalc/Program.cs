using SimpleCalc.Calculations;
using SimpleCalc.Answer;
using SimpleCalc.Again;

namespace SimpleCalc
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose an operation between two numbers and calculate its result");
            Console.WriteLine("-Choose a method of operation. + - * / %");

            string? opStr = Console.ReadLine();
            if (opStr == null)
            {
                Invalid.InvalidInput();
            }
            else if (opStr == "+") { Addition.AdditionCalc(); }
            else if (opStr == "-") { Subtraction.SubtractionCalc(); }
            else if (opStr == "*") { Multiplication.MultiplicationCalc(); }
            else if (opStr == "/") { Division.DivisionCalc(); }
            else if (opStr == "%") { Modulus.ModulusCalc(); }
            else { Invalid.InvalidInput(); Program.Main(); }

            //if true run Main again
            if (TryAgain.TryPrompt() == true)
            {
                Program.Main();
            }
        }
    }
}

