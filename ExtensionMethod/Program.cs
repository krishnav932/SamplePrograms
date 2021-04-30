using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class Class1
    {
        public void hello1()
        {
            Console.WriteLine("Hello1 method is called");
        }
    }
    public static class Class2
    {
        public static void hello2(this Class1 c1) //extension method(adding new features to existing object)
        {
            Console.WriteLine("Hello2 method is called");
        }
    }
    class MainClass
    { 
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.hello1();
            c1.hello2(); // class1 object is added with the new feature of hello2 method
        }
    }
}
