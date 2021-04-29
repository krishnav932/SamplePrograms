using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[20];
            int[] a2 = new int[20];
            int[] a3 = new int[20];
            int x, y, z, i, j, k;
            Console.Write("Enter number of elements to be stored in the 1st array :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter {0} elements in the array :\n", x);
            for (i = 0; i < x; i++)
            {
                Console.Write("element - {0} : ", i);
                a1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter number of elements to be stored in the 2nd array :");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in the array :\n", y);
            for (i = 0; i < y; i++)
            {
                Console.Write("element - {0} : ", i);
                a2[i] = Convert.ToInt32(Console.ReadLine());
            }
            z = x + y; // third array size
            for (i = 0; i < x; i++) //inserting into third array
            {
                a3[i] = a1[i];
            }
            for (j = 0; j < y; j++)
            {
                a3[i] = a2[j];
                i++;
            }
            // sort the array in ascending order
            for (i = 0; i < z; i++) 
            {
                for (k = 0; k < z - 1; k++)
                {

                    if (a3[k] >= a3[k + 1]) //if next no. is greater then swapping
                    {
                        j = a3[k + 1]; //using swapping concept
                        a3[k + 1] = a3[k];
                        a3[k] = j;
                    }
                }
            }
            Console.Write("\nThe merged array in ascending order is :\n");
            for (i = 0; i < z; i++)
            {
                Console.Write("{0} ", a3[i]);
            }
            Console.Write("\n\n");
        }
    }

}
  