using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new List<int>();
            num.Add(2);
            num.Add(3);
            num.Add(5);
            num.Add(7);
            Console.WriteLine("LIST 1: " + num.Count);
            // other way
            var numbers = new List<int>() { 2, 3, 5, 7 };
            Console.WriteLine("LIST 2: " + numbers.Count);
            foreach (var n in num)//printing the elements
            {
                System.Console.WriteLine("{0}", n);
            }
            //reverse printing the elements
            for (int i = num.Count - 1; i >= 0; i--)
            {
                Console.WriteLine("Reverse {0}", num[i]);
            }
            //insert
            numbers.InsertRange(1, new List<int>() { 3,4,9,8 });
            Console.WriteLine();
            foreach (var value in numbers)
            {
                Console.WriteLine("RESULT: " + value);
            }
        }
    }
}
