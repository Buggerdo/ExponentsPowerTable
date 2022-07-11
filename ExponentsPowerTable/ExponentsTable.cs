using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(String.Format($"{number, space}{squared, space}{cubed, space}"));
            Console.WriteLine(String.Format($"{dashes, space}{dashes, space}{dashes, space}"));

            for(int i = 1; i <= input; i++)
            {
                Console.WriteLine(string.Format($"{i, space}{Math.Pow(i, 2), space}{Math.Pow(i, 3), space}"));
            }
        }
    }
}
