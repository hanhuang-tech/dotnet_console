using System;

namespace SimpleCalc.Input
{
    internal class PleaseEnter
    {
        public static void EnterCalc()
        {
            Console.WriteLine("Please enter the number of operations required for your calculation");
            string? opNum = Console.ReadLine();
            int.TryParse(opNum, out int opNumInt);
            if (opNumInt > 0)
            {
                Console.WriteLine("You would like to do " + opNumInt + " operation(s), requiring " + (opNumInt + 1) + " numbers. Is this correct?");
                Console.WriteLine("- yes/no");
                string? confirmNumOfOp = Console.ReadLine();
                if (confirmNumOfOp == "yes")
                {
                }
                else if (confirmNumOfOp == "no")
                {
                    Console.WriteLine(Environment.NewLine);
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
        public static int EnterNumOne(string num)
        {
            if (Int32.TryParse(num, out int numInt))
            { ConfirmInput.EnterNumber(num); return numInt; }
            else
            {
                ConfirmInput.InvalidInput();    //invalid input
                PleaseEnter.EnterNumOne(num); //start again
                return numInt;
            }
        }

        public static string EnterSign(string sign)
        {

            ConfirmInput.EnterSign(sign);
            if (sign == "+" || sign == "-" || sign == "*" || sign == "/" || sign == "%")
            {
                return sign;
            }
            else
            {
                ConfirmInput.InvalidInput();    //invalid input
                PleaseEnter.EnterSign(sign); //start again
                return sign;
            }
        }

        public static int EnterNumTwo(string num)
        {
            if (Int32.TryParse(num, out int numInt))
            {
                ConfirmInput.EnterNumber(num);
                return numInt;
            }
            else
            {
                ConfirmInput.InvalidInput();    //invalid input
                PleaseEnter.EnterNumTwo(num); //start again
                return numInt;
            }
        }


    }
}

