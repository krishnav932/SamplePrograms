using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDataType
{
    class Dynamic
    {
        dynamic Data = 12;
        public int Method(int A, int B)
        {
            return (A + B) * Data;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             
            dynamic obj = new Dynamic();
            dynamic value1 = 10;
            dynamic value2 = 11;
            dynamic str = "Your Result Is: ";
            Console.WriteLine(str + obj.Method(value1, value2)); 
            obj = "Ram"; //string
            Console.WriteLine(obj);
            obj = 12345; // Integer  
            Console.WriteLine(obj); 
            obj = 123.45;// Float 
            Console.WriteLine(obj);  
            obj = false; //Boolean
            Console.WriteLine(obj);
            obj = new Dictionary<int, string>();//Dictionary
            obj[0] = "Hyderabad";
            obj[1] = "chennai";
            obj[2] = "Warangal";
            obj[3] = "Khammam";
            foreach (var index in obj.Keys)
            {
                Console.WriteLine(obj[index]);
            }
            Console.ReadLine();
        }
    }
}
