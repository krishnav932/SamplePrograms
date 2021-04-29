using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
	class UnaryOperator
	{
		public void UnaryMethod()
		{
            int x = 100;
            int result;

            Console.WriteLine("x is " + x);
            result = x++;
            Console.WriteLine("Post increment value is " + x);

            Console.WriteLine("x is " + x);
            result = x--;
            Console.WriteLine("Post decrement value is " + x);

            Console.WriteLine("x is " + x);
            result = ++x;
            Console.WriteLine("Pre increment value is " + x);

            Console.WriteLine("x is " + x);
            result = --x;
            Console.WriteLine("Pre decrement value is " + x);
        }
		
	}
}
