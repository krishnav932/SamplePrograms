using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    class NestedIf
    {
        public void NestedMethod()
        {
			int var1, var2;
			Console.WriteLine("Input the value of var1:");
			var1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Input the value of var2:");
			var2 = int.Parse(Console.ReadLine());
			if (var1 != var2)
			{
				Console.WriteLine("var1 is not equal to var2\n");
				//Nested if else
				if (var1 > var2)
				{
					Console.WriteLine("var1 is greater than var2\n");
				}
				else
				{
					Console.WriteLine("var2 is greater than var1\n");
				}
			}
			else
			{
				Console.WriteLine("var1 is equal to var2\n");
			}
			
		}
    }
}
