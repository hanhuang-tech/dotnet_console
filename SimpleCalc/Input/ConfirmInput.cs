namespace SimpleCalc.Input
{
    internal class ConfirmInput
    {
        public static void EnterSign(string sign)
        {
            if (sign == "+" || sign == "-" || sign == "*" || sign == "/" || sign == "%")
            { Console.WriteLine("Your input was: " + sign); }
            else { ConfirmInput.InvalidInput(); };
        }

        public static void EnterNumber(string num)
        {
            if (System.Int32.Parse(num) is int)
            { Console.WriteLine("Your input is: " + num + " "); }
            else { ConfirmInput.InvalidInput(); };
        }

        //General invalid input prompt
        public static void InvalidInput()
        { Console.WriteLine("!Invalid, please check your input and try again"); }
    }
}
