using static System.Console;

namespace ExponentsPowerTable
{
    internal class ExponentsTable
    {
        public static void Table(int input)
        {
            string number = "Number";
            string squared = "Squared";
            string cubed = "Cubed";
            string dashes = "=======";
            const int space = -10;

            WriteLine(String.Format($"{number, space}{squared, space}{cubed, space}"));
            WriteLine(String.Format($"{dashes, space}{dashes, space}{dashes, space}"));

            for(int i = 1; i <= input; i++)
            {
                WriteLine(string.Format($"{i, space}{Math.Pow(i, 2), space}{Math.Pow(i, 3), space}"));
            }
        }
    }
}
