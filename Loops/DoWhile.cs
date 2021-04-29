using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class DoWhile
    {
        public void DoWhileMethod()
        {
            int number, sum = 0;
            do                           //till the number is given zero 
            {
                Console.WriteLine("enter a number ");
                number =int.Parse(Console.ReadLine());
                sum += number;
            } while (number != 0);

            Console.WriteLine("sum={0}", sum);
        }
    }
}
