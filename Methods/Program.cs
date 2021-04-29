using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //method overriding
            //Parent p = new Parent();
            //p.House();
            //Child c = new Child();
            //c.House();
            //GrandChild g = new GrandChild();
            //g.House();


            Calculator.Add();
            Calculator.Add(2, 3);
            Calculator.Add(5.5f, 6.5f);
            Calculator.Add("Hello World");
            Console.Read();
        }
    }
    static class Calculator
    {
        

        //method overloading
        public static void Add()
        {
            Console.WriteLine("Cant add without the values");
        }
        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void Add(float x, float y)
        {
            Console.WriteLine("Addition of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void Add(string s)
        {
            Console.WriteLine("{0} is not a number", s);
        }
    }
}
