using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class TerinaryOperator
    {
        public void TerinaryMethod()
        {

        int number = 10;
        string result;

        result = (number % 2 == 0)? "Even Number" : "Odd Number";
		Console.WriteLine("{0} is {1}", number, result);
        }
	}
}

