using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentsPowerTable
{
    internal class Exponents
    {
        public Exponents()
        {
            int input = GetInteger.GetInt();
            ExponentsTable.Table(input);
        }
    }
}
