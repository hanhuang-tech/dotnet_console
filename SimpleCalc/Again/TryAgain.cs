using SimpleCalc.Answer;

namespace SimpleCalc.Again
{
    internal class TryAgain
    {
        public static bool TryPrompt()
        {
            Console.WriteLine("-Try again? yes/no");
            string? tryAgain = Console.ReadLine();
            if (tryAgain == "yes")
            { Console.WriteLine(Environment.NewLine); return true; }
            else if (tryAgain == "no") { Console.WriteLine("Bye~"); return false; }
            else { Invalid.InvalidInput(); TryPrompt(); return false; }
        }
    }
}
