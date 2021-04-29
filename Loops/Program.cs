using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Nested Loop
            NestedLoop nl = new NestedLoop();
            nl.PatternMethod();
            nl.NestedWhile();
            nl.NestedDoWhile();

            //For Each

            ForEach fe = new ForEach();
            fe.ItemCount();


            //Do While Loop
            //DoWhile dw = new DoWhile();
            //dw.DoWhileMethod();


            //while loop

            //WhileLoop wl = new WhileLoop();
            //wl.WhileMethod();

            //For Loop
            Console.WriteLine("enter an initial number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a final number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of rows");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int n = a; n <= b; n++)
            {
                for (int i = 1; i <= k; i++)
                {
                    int j = n * i;
                    Console.WriteLine("{0} x {1} = {2} ", n, i, j);
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
