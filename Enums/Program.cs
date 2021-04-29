using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            customer[] customers = new customer[3];
            customers[0] = new customer
            {
                name = "Ram",
                gender = Gender.male
            };
            customers[1] = new customer
            {
                name = "Geetha",
                gender = Gender.female
            };
            customers[2] = new customer
            {
                name = "sam",
                gender = Gender.unknown
            };

            foreach (customer c in customers)
            {

                Console.WriteLine("the name is {0}, gender is {1}", c.name, getgender(c.gender));

            }

        }

        public static string getgender(Gender gender)

        {
            switch (gender)
            {
                case Gender.unknown:
                    return "unknown";
                case Gender.male:
                    return "male";
                case Gender.female:
                    return "female";
                default:
                    return "invalid data detected";

            }

        }
    }

    public enum Gender

    {
        unknown,
        male,
        female
    }

    public class customer

    {
        public string name { get; set; }
        public Gender gender { get; set; }

    }
}
  
