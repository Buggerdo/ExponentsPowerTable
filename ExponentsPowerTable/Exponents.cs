using static ExponentsPowerTable.ExponentsTable;
using static ExponentsPowerTable.GetInteger;

namespace ExponentsPowerTable
{
    internal class Exponents
    {
        public Exponents()
        {
            int input = GetInt();
            Table(input);
        }
    }
}
