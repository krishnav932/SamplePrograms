using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    class SampleIfElse
    {
            public void IfElseMethod()
            {
                Console.WriteLine("enter your percentage");
                int percentage = int.Parse(Console.ReadLine());
                if (percentage >= 90)
                {
                    Console.WriteLine("A grade");
                }
                else if (percentage >= 80 && percentage < 90)
                {
                    Console.WriteLine("B grade");
                }
                else if (percentage >= 60 && percentage < 80)
                {
                    Console.WriteLine("C grade");
                }
                else if (percentage >= 35 && percentage < 60)
                {
                    Console.WriteLine("D grade");
                }
                else
                {
                    Console.WriteLine("F grade");
                }
            }
        }
    }

