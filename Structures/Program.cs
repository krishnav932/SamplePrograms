using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct Employee
    {
        public string name;
        public string fatherName;
        public string job;
        public int id;
    };

    public class testStructure
    {
        public static void Main(string[] args)
        {
            Employee emp1;  
            Employee emp2;

            
            emp1.name = "Ram";
            emp1.fatherName = "Ramesh";
            emp1.job = "clerk";
            emp1.id = 101;

            emp2.name = "Shyam";
            emp2.fatherName = "Das";
            emp2.job = "officer";
            emp2.id = 102;

            Console.WriteLine("emp 1 name : {0}", emp1.name);
            Console.WriteLine("emp 1 fatherName : {0}", emp1.fatherName);
            Console.WriteLine("emp 1 job : {0}", emp1.job);
            Console.WriteLine("emp 1 id :{0}", emp1.id);

            
            Console.WriteLine("\nemp 2 name : {0}", emp2.name);
            Console.WriteLine("emp 2 fatherName : {0}", emp2.fatherName);
            Console.WriteLine("emp 2 job : {0}", emp2.job);
            Console.WriteLine("emp 2 id : {0}", emp2.id);

            Console.ReadLine();
        }
    }
}
