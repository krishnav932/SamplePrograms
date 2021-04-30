using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomer
    {
        void Print();
    }
    interface I2
    {
        void Print();
    }
    class Customer : ICustomer, I2  //multiple inheritance in interfaces
    {
        public void Print()
        {
            Console.WriteLine("interface I2Method");
        }

         void I2.Print()
        {
            Console.WriteLine("interface print method");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            ((I2)(c1)).Print();
            ((ICustomer)(c1)).Print();

        }
    }
}
