
namespace ExponentsPowerTable
{
    internal class Continue
    {
        public static bool IsContinue()
        {
            string[] yes = new[] { "y" , "yes", "yup" };
            string[] no = new[] { "n" , "no" , "nope" };
            do
            {
                Console.Write("\nContinue Y/N? ");
                string input = Console.ReadLine().ToLower().Trim();
                if(yes.Contains(input)) return true;
                if(no.Contains(input)) return false; 
            } while(true);          
        }
    }
}
