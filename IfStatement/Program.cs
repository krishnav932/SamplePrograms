using IfStatement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfCondition
{
    class Program
    {

        static void Main(string[] args)
        {
            
           

            Console.WriteLine("enter any alphabet");
            string ch = Console.ReadLine();
            if(ch == "v")
            {
                Console.WriteLine("violet color");
            }
            if (ch == "i")
            {
                Console.WriteLine("indigo color");
            }
            if (ch == "b")
            {
                Console.WriteLine("blue color");
            }
            if (ch == "g")
            {
                Console.WriteLine("green cgolor");
            }
            if (ch == "y")
            {
                Console.WriteLine("yellow color");
            }
            if (ch == "o")
            {
                Console.WriteLine("orange color");
            }
            if (ch == "r")
            {
                Console.WriteLine("red color");
            }
            Console.ReadLine();

            //using other logic

            //if(ch== "v" || ch=="i" || ch=="b" || ch== "g" || ch=="y" || ch=="o" || ch== "r")
            //{
            //    Console.WriteLine("rainbow color");
            //    Console.ReadLine();
            //}


            //SampleIfElse sie = new SampleIfElse();
            //sie.IfElseMethod();

            //NestedIf ni = new NestedIf();
            //ni.NestedMethod();

            Switch s = new Switch();
            s.SwitchMethod();
        }
    }
}

