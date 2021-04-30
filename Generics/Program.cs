using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DictionaryCollection

{

    class DictionaryCollection

    {

        static void Main(string[] args)

        {

            //Dictionary<String, object> dt = new Dictionary<string, object>(); 

            //dt.Add("Eid", 1010); 

            //dt.Add("Ename", "scott"); 

            //dt.Add("Job", "Manager"); 

            //dt.Add("Salary", 25000.00); 

            //dt.Add("Mgrid", 1002); 

            //dt.Add("Phone", "987645324"); 

            //dt.Add("Email", "scott@gmail.com"); 

            //dt.Add("Dname", "sales"); 

            //dt.Add("Location", "Mumbai"); 

            //dt.Add("Did", 30); 

            //foreach(string key in dt.Keys) 

            //{ 

            //    Console.WriteLine(key + ":" + dt[key]); 

            //} 

            //Console.ReadLine(); 



            // user defined type


            List<Customer> Customers = new List<Customer>();

            Customer c1 = new Customer { custId = 101, name = "scott", city = "hyderabad", balance = 25000.00 };

            Customer c2 = new Customer { custId = 102, name = "smith", city = "chennai", balance = 29000.00 };

            Customer c3 = new Customer { custId = 103, name = "dave", city = "delhi", balance = 34000.00 };

            Customer c4 = new Customer { custId = 104, name = "david", city = "hyderabad", balance = 59000.00 };

            Customers.Add(c1);

            Customers.Add(c2);

            Customers.Add(c3);

            Customers.Add(c4);

            foreach (Customer obj in Customers)

            {

                Console.WriteLine(obj.custId + " " + obj.name + " " + obj.city + " " + obj.balance);

            }

            Console.ReadLine();

        }

    }

}

