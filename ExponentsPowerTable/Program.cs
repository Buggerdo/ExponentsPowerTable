using static ExponentsPowerTable.Continue;

namespace ExponentsPowerTable
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                _ = new Exponents();
            } while(IsContinue());
        }
    }
}