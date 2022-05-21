using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    internal class BoolInput
    {
        public static bool ValidSign(string sign)
        {
            if (sign == "+" || sign == "-" || sign == "*" || sign == "/" || sign == "%")
            { return true; }
            else
            { return false; }
        }
        public static bool ValidNum(string sign)
        {
            if (sign == "+" || sign == "-" || sign == "*" || sign == "/" || sign == "%")
            { return true; }
            else
            { return false; }
        }
    }
}
