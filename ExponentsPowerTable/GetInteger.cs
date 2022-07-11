using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentsPowerTable
{
    internal class GetInteger
    {
        public static int GetInt()
        {
            int number = 0;
            bool isGoodNumber;
            do
            {
                Console.Clear();
                Console.Write("Please enter an integer :");
                string input = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(input);
                    if(number > 0)
                    {
                        isGoodNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("The number must be positive.");
                        isGoodNumber = false;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Sorry that is not a valid input.");
                    isGoodNumber = false;
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Sorry that number is too big.");
                    isGoodNumber = false;
                }
                if(!isGoodNumber)
                {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                }
            } while(!isGoodNumber);
            return number;
        }
    }
}
