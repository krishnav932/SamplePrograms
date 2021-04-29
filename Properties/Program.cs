using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        private int id;
        private string name;
        private int passmark=35; //readonly

        public int PassMark
        {
            get
            {
                return this.passmark;
            }
        }

        public string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("name can't be null or empty");
                }
                this.name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this.name) ? "no name" : this.name;
            }
        }

        public int Id
        {
            set
            {
                if(value <= 0)
                {
                    throw new Exception("student id can't be negative");
                }
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        static void Main(string[] args)
        {
            Student c1 = new Student();
            c1.id = 101;
            c1.name = "ram";
            Console.WriteLine("student id = {0}",c1.id);
            Console.WriteLine("student name = {0}", c1.name);
            Console.WriteLine("student passmark = {0}", c1.passmark);
        }
    }
}
