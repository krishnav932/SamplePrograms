using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Name of the customer1:{0} {1}, Location:{2}, Age:{3}";
            string msg1 = string.Format(s1, "Ram", "Reddy", "Hyderabad", 32);
            string s2 = "Name of the customer2:{0} {1}, Location:{2}, Age:{3}";
            string msg2 = string.Format(s2, "shyam", "sharma", "Mumbai", 21);
            string s3 = "Name of the customer3:{0}, Location:{1}, {2}, Age:{3}";
            string msg3 = string.Format(s3, "krishna", "chennai", "Tamil Nadu", 22);
            Console.WriteLine("Customer1: {0}", msg1);
            Console.WriteLine("Customer2: {0}", msg2);
            Console.WriteLine("Customer3: {0}\n", msg3);
            Console.WriteLine(msg1 + msg2 + msg3); //concatanation operation
            Console.ReadLine();
        }
    }
}
