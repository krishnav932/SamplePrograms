using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class LogicalOperator
    {
		public void LogicalMethod()
		{
			bool result;
			int firstNumber = 10, secondNumber = 20;
			result = (firstNumber == secondNumber) || (firstNumber > 2); // OR operator
			Console.WriteLine(result);
			result = (firstNumber == secondNumber) && (firstNumber > 2); // AND operator
			Console.WriteLine(result);
		}
	}
}
