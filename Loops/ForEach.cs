using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class ForEach
    {
        public void ItemCount()
        {
            char[] Item = { 'm', 's', 'm', 'o', 'p','v', 's', 's','v', 'o', 'm', 's', 'o', 'p','o','v','d','i' };
            int mask = 0, sanitizer = 0, pulseoximeter= 0, ppekit=0, vaccine=0, medicine=0,injection=0;
            foreach (char i in Item)
            {
                if (i == 'm')
                    mask++;
                else if (i == 's')
                    sanitizer++;
                else if (i == 'o')
                    pulseoximeter++;
                else if (i == 'p')
                    ppekit++;
                else if (i == 'v')
                    vaccine++;
                else if (i == 'd')
                    medicine++;
                else if (i == 'i')
                    injection++;
            }
            Console.WriteLine("Number of mask = {0}", mask);
            Console.WriteLine("Number of sanitizer = {0}", sanitizer);
            Console.WriteLine("Number of pulseoximeter = {0}", pulseoximeter);
            Console.WriteLine("Number of ppekit = {0}", ppekit);
            Console.WriteLine("Number of vaccine = {0}", vaccine);
            Console.WriteLine("Number of medicine = {0}", medicine);
            Console.WriteLine("Number of injection = {0}", injection);
        }
    }
}
