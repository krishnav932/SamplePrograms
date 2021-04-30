using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Nullable
    {
        public Nullable<int> i;
    }
    class Customer
    {
        
        static void Main(string[] args)
        {
            int? customerId = null;
            string customerName = null; //reference type dont require nullable types
            Nullable<char> customerGender = null; //another way of declaring nullable types
            double? customerSalary = null;
            Console.WriteLine(customerId);
            Console.WriteLine(customerName);
            Console.WriteLine(customerGender);
            Console.WriteLine(customerSalary);
            Console.WriteLine();

            Console.WriteLine(customerId.GetValueOrDefault()); //returns actual value if it is not null and the default value if it is null.
            //above statement prints 0

            Nullable mycls = new Nullable();
            if (mycls.i == null)
                Console.WriteLine("Null");
        }   
    }
}
