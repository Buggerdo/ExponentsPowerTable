using static System.Console;


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
                Clear();
                Write("Please enter an integer :");
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
                        WriteLine("The number must be positive.");
                        isGoodNumber = false;
                    }
                }
                catch(FormatException)
                {
                    WriteLine("Sorry that is not a valid input.");
                    isGoodNumber = false;
                }
                catch(OverflowException)
                {
                    WriteLine("Sorry that number is too big.");
                    isGoodNumber = false;
                }
                if(!isGoodNumber)
                {
                    WriteLine("Press any key to continue.");
                    ReadLine();
                }
            } while(!isGoodNumber);
            return number;
        }
    }
}
