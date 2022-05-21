namespace SimpleCalc
{
    internal class EnterInput
    {
        public static void EnterSign(string sign)
        {
            if (sign == "+" || sign == "-" || sign == "*" || sign == "/" || sign == "%")
            {
                Console.WriteLine("Your input was: " + sign);
            }
            else
            {
                Console.WriteLine("Invalid! Please enter a valid input");
            };
        }

        public static void EnterNumber(string num)
        {
            if (System.Int32.Parse(num) is int)
            {
                string numInput = "Your input is: " + num + " ";
                Console.WriteLine(numInput);
            }
            else
            {
                Console.WriteLine("Invalid! Please enter a valid input");
            };
        }
    }
}
