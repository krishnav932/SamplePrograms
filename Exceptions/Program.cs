using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ExceptionClass
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter 1st number:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("enter 2nd number:");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("The Result is :"+z);
            } 
            catch(DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(FormatException ex2)
            {
                Console.WriteLine("input must be numeric value"); //another way
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block is executed");
            }
            Console.WriteLine("end of the program");
        }
    }
}
