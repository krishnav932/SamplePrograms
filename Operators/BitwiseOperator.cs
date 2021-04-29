using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class BitwiseOperator
    {
        public void BitwiseMethod()
        {
            int x = 10, y = 20, result;

            // Bitwise AND Operator. Result of AND is 1 only if both bits are 1.
            result = x & y;
            Console.WriteLine("Bitwise AND: " + result);

            // Bitwise OR Operator. Result of OR is 1 any of the two bits is 1.
            result = x | y;
            Console.WriteLine("Bitwise OR: " + result);

            // Bitwise XOR Operator.Result of XOR is 1 if the two bits are different.
            result = x ^ y;
            Console.WriteLine("Bitwise XOR: " + result);
        }
    }
}
