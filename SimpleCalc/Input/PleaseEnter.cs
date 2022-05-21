using System;

namespace SimpleCalc.Input
{
    internal class PleaseEnter
    {
        public static void EnterCalc()
        {
            Console.WriteLine("- Please enter the number of operations required for your calculation");
            string opNum = Console.ReadLine();
            Int32.TryParse(opNum, out int opNumInt);
            if (opNumInt > 0)
            {
                Console.WriteLine("- You would like to do " + opNumInt + " operation(s), requiring " + (opNumInt + 1) + " numbers. Is this correct?");
                Console.WriteLine("- yes/no");
                string confirmNumOfOp = Console.ReadLine();
                if (confirmNumOfOp == "yes") { }    //continue
                else if (confirmNumOfOp == "no")
                {
                    PleaseEnter.EnterCalc();
                }   //start again
                else
                {
                    ConfirmInput.InvalidInput();
                    Console.WriteLine(Environment.NewLine);
                    PleaseEnter.EnterCalc();
                };
            }    //continue
            else
            {
                ConfirmInput.InvalidInput();    //invalid input
                Console.WriteLine(Environment.NewLine);
                PleaseEnter.EnterCalc(); //start again
            }
        }
        public static void EnterSign()
        {
            Console.WriteLine("- Please enter an arithmetic operator to use for your calculation");
            Console.WriteLine("- Enter: + - * / %");
            string opSign = Console.ReadLine();
            ConfirmInput.EnterSign(opSign);
            if (opSign == "+" || opSign == "-" || opSign == "*" || opSign == "/" || opSign == "%")
            {
                ConfirmInput.InvalidInput();    //invalid input
                PleaseEnter.EnterSign(); //start again
            }
        }

        public static void EnterNum()
        {
            Console.WriteLine("- Please enter a number for your calculation");
            string inputNum = Console.ReadLine();
            ConfirmInput.EnterNumber(inputNum);
            if (System.Int32.Parse(inputNum) is int) { }    //continue
            else
            {
                ConfirmInput.InvalidInput();    //invalid input
                PleaseEnter.EnterNum(); //start again
            }
        }
    }
}

