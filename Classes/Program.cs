using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Triangle
    {
        public int bases;
        public int height;
    }
    class TriangleArea
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle();
            Triangle triangle2 = new Triangle();
            double area = 0.0;

            triangle1.height = 5;
            triangle1.bases = 2;

            triangle2.height = 10;
            triangle2.bases = 2;


            area = 0.5 * triangle1.bases * triangle1.height;
            Console.WriteLine("Area of Triangle1 : {0}", area);

            area = 0.5 * triangle2.bases * triangle2.height;
            Console.WriteLine("Area of Triangle2 : {0}", area);
            Console.ReadKey();
        }
    }
}
