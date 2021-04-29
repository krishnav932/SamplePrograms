using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
     class Employee
    {
        public int empId { get; set; }
        public double salary { get; set; }
        public string name { get; set; }
        public char gender { get; set; }
        public bool fullTime { get; set; }

    }

    class Program
    { 
    static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empId = 101;
            emp.salary = 50000.00;
            emp.name = "Ram";
            emp.gender = 'M';
            emp.fullTime = true;
            Console.WriteLine("Emp Id is {0} ", emp.empId);
            Console.WriteLine("Emp Salary is {0} ", emp.salary);
            Console.WriteLine("Emp Name is {0} ", emp.name);
            Console.WriteLine("Emp Gender is {0} ", emp.gender);
            Console.WriteLine("Is Emp Fulltime = {0} ", emp.fullTime);
        }
    }
}
