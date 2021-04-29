using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float yearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float commission;
    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "Ram";
            FTE.lastName = "prasad";
            FTE.yearlySalary = 50000;
            FTE.PrintFullName();
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "sachin";
            PTE.lastName = "tendulkar";
            PTE.commission = 40;
            PTE.PrintFullName();
        }
    }
}
