using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class BasicProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no. of rows\n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i=1; i<=n; i++)
            {
                for(int j=1; j<=n;j++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
