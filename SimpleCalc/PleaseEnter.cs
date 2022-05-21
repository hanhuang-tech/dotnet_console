using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    internal class PleaseEnter
    {
        public static void EnterSign()
        {
            Console.WriteLine("Please enter your method of operation. (+ - / * %)");
            string opSign = Console.ReadLine();
            EnterInput.EnterSign(opSign);
            if (BoolInput.ValidSign(opSign) == false)
            {
                PleaseEnter.EnterSign();
            }
        }

        public static void EnterNum()
        {
            Console.WriteLine("Please enter the first number of your calculation");
            string firstCalc = Console.ReadLine();
            EnterInput.EnterNumber(firstCalc);
            if (BoolInput.ValidNum(firstCalc) == false)
            {
                PleaseEnter.EnterNum();
            }
        }
    }
}

