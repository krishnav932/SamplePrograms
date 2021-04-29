using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA.TeamA; //userdefined namespace

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("TeamA print method");
            }
        }
    }

    namespace ProjectA
    {
        namespace TeamB
        {
            class ClassA
            {
                public static void Print()
                {
                    Console.WriteLine("TeamB print method");
                }
            }
        }

        class MainMethod
        {
            public static void Main(string[] args)
            {
                ClassA.Print();
                ProjectA.TeamB.ClassA.Print();
            }
        }

    }
}
