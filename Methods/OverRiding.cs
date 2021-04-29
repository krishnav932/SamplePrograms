using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Parent
    {
        virtual public void House()
        {
            Console.WriteLine("Ground Floor");
        }
    }
    class Child:Parent
    {
        public override void House()
        {
            Console.WriteLine("First Floor");
        }
    }
    class GrandChild : Child
    {
        public override void House()
        {
            Console.WriteLine("Second Floor");
        }
    }
}
