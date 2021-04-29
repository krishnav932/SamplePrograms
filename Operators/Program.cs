using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class RelationalOperators
    {
        static void Main(string[] args)
        {
			//LogicalOperator lop = new LogicalOperator();
			//lop.LogicalMethod();

			//TerinaryOperator top = new TerinaryOperator();
			//top.TerinaryMethod();

			UnaryOperator um = new UnaryOperator();
			um.UnaryMethod();

			BitwiseOperator bo = new BitwiseOperator();
			bo.BitwiseMethod();

			bool result;
			int firstNumber = 10, secondNumber = 20;

			result = (firstNumber == secondNumber);
			Console.WriteLine("== returns {0}", result);

			result = (firstNumber > secondNumber);
			Console.WriteLine("> returns {0}", result);

			result = (firstNumber < secondNumber);
			Console.WriteLine("< returns {0}", result);

			result = (firstNumber >= secondNumber);
			Console.WriteLine(">= returns {0}", result);

			result = (firstNumber <= secondNumber);
			Console.WriteLine("<= returns {0}", result);

			result = (firstNumber != secondNumber);
			Console.WriteLine("!= returns {0}", result);
		}
    }
}
