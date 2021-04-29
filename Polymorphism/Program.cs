using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kudv_polymorphism
{
    public class Employee
    {
        public string firstName = "FirstName";
        public string lastName = "LastName";

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - FullTimeEmployee");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - PartTimeEmployee");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - TemporaryEmployee");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();
            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}
