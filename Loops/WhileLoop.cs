using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class WhileLoop
    {
        public void WhileMethod()
        {
            int n, r, sum=0,t ;
            Console.WriteLine("enter a number");
            n =int.Parse(Console.ReadLine());
            t = n;
            while(n>0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine("sum of the digits in {0} is {1} ", t, sum);
        }

    }
}
