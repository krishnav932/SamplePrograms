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
        void I2Method();
    }
    class Customer : ICustomer, I2  //multiple inheritance in interfaces
    {
        public void I2Method()
        {
            Console.WriteLine("interface I2Method");
        }

        public void Print()
        {
            Console.WriteLine("interface print method");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print();
            c1.I2Method();
        }
    }
}
