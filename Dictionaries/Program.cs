using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
          
               
                Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

                // Create Customer Objects
                Customer customr1 = new Customer()
                {
                    ID = 101,
                    Name = "Ram",
                    Salary = 50000
                };

                Customer customr2 = new Customer()
                {
                    ID = 102,
                    Name = "Shyam",
                    Salary = 60000
                };

                Customer customr3 = new Customer()
                {
                    ID = 104,
                    Name = "krishna",
                    Salary = 70000
                };

                // Adding customer objects to the dictionary
                dictionaryCustomers.Add(customr1.ID, customr1);
                dictionaryCustomers.Add(customr2.ID, customr2);
                dictionaryCustomers.Add(customr3.ID, customr3);

                Console.WriteLine("All customer keys and values in customer dictionary");
                foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
                {
                    Console.WriteLine("Key = " + customerKeyValuePair.Key);
                    Customer cust = customerKeyValuePair.Value;
                    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                }
                Console.WriteLine();

               
                // To get all the keys in the dictionary
                Console.WriteLine("All Keys in Customer Dictionary");
                foreach (int key in dictionaryCustomers.Keys)
                {
                    Console.WriteLine(key);
                }

                // To get all the values in the dictionary
                Console.WriteLine("All Customer objects in Customer Dictionary");
                foreach (Customer customer in dictionaryCustomers.Values)
                {
                    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
                }

                //checking if the key already exists
                if (!dictionaryCustomers.ContainsKey(101))
                {
                    dictionaryCustomers.Add(101, customr1);
                }

            }
        }

        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
    }
    
