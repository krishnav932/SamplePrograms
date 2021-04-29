using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class ParameterConstrctor
    {
        public int a, b,c;
        public ParameterConstrctor(int x, int y)   
        {
            a = x;
            b = y;
        }

        public ParameterConstrctor(int x, int y, int z) //constructor overloading
        {
            a = x;
            b = y;
            c = z;
        }
    }
    class MainClass
    {
        static void Main()
        {
            ParameterConstrctor p = new ParameterConstrctor(100, 200);    
            Console.WriteLine("value of a=" + p.a);
            Console.WriteLine("value of b=" + p.b);
            Console.WriteLine();

            ParameterConstrctor h = new ParameterConstrctor(300,400,500);
            Console.WriteLine("value of a=" + h.a);
            Console.WriteLine("value of b=" + h.b);
            Console.WriteLine("value of c=" + h.c);

            Console.Read();
        }
    }
}
