using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class NestedLoop
    {
        public void PatternMethod()
        {
            Console.WriteLine("enter the no. of rows\n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void NestedWhile()
        {
            int a = 1, b = 1;
            while (a <= 5)
            {
                b = 1;
                while (b <= 5)
                {
                    Console.Write(b);
                    b++;
                }
                Console.WriteLine();
                a++;
            }
        }
        public void NestedDoWhile()
        {
            do
            {
                Console.WriteLine("outerloop ");
                do
                {
                    Console.WriteLine("innerloop ");
                }
                while (1 == 2);
            }
            while (1==2);
        }
    }
    
}

