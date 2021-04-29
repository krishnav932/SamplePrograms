using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class DelegateClass
    {
        
        public delegate void Add(int a, int b);
        public delegate void Sub(int a, int b);
        public void Sum(int a, int b)
        {
            Console.WriteLine("(20+ 10) = {0}", a + b);
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine("(20 - 10) = {0}", a - b);
        }

        public static void Main(String[] args)
        {
            DelegateClass obj = new DelegateClass();

            // creating object of delegate 
            Add delAdd = new Add(obj.Sum);// pass the parameter using class object "obj"
            Sub delSub = new Sub(obj.Subtract);

            delAdd(20, 10); // pass the values to the methods by delegate object
            delSub(20, 10);

            //Another way by using "Invoke" method
            //delAdd.Invoke(20, 10);
            //delSub.Invoke(20, 10);
        }
    }
}
   
