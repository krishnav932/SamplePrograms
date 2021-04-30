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
        public delegate void Div(int a, int b);
        public void Sum(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}",a,b, a + b);
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}",a,b, a - b);
       }

        public void Division(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}",a,b, a / b);
            Console.WriteLine($"{a} / {b} = {a/b}");
            Console.WriteLine(a+" / "+b+" = "+a/b);
        }
        public static void Main(String[] args)
        {
            DelegateClass obj = new DelegateClass();

            // creating object of delegate 
            Add delAdd = new Add(obj.Sum);// pass the parameter using class object "obj"
            Sub delSub = new Sub(obj.Subtract);
            Div delDiv = new Div(obj.Division);

            delAdd(20, 10); // pass the values to the methods by delegate object
            delSub(40, 50);
            delDiv(60, 30);

            //Another way by using "Invoke" method
            //delAdd.Invoke(20, 10);
            //delSub.Invoke(20, 10);
        }
    }
}
   
