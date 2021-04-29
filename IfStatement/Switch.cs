using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    class Switch
    {
        public void SwitchMethod()
        {
            int totalPrice = 0;
            start:
            Console.WriteLine("select your cooldrink: 1-Thumbsup, 2-Mazaa, 3-Pepsi ");
            int coolDrink=int.Parse(Console.ReadLine());
            switch(coolDrink)
            {
                case 1:
                    {
                        Console.WriteLine("select the size of thumbsup: 1 - 500ml, 2 - 1Litre, 3 - 1.5Litre");
                        int thumbsupSize=int.Parse(Console.ReadLine());
                        switch(thumbsupSize)
                        {
                            case 1:
                                {
                                    totalPrice += 50;
                                    break;
                                }
                            case 2:
                                {
                                    totalPrice += 100;
                                    break;
                                }
                            case 3:
                                {
                                    totalPrice += 150;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("your choice invalid, please try again....");
                                    goto start;
                                }
                        }
                        break; 
                    }
                case 2:
                    {
                        Console.WriteLine("select the size of Mazaa: 1 - 500ml, 2 - 1Litre, 3 - 1.5Litre");
                        int mazaa = int.Parse(Console.ReadLine());
                        switch (mazaa)
                        {
                            case 1:
                                {
                                    totalPrice += 50;
                                    break;
                                }
                            case 2:
                                {
                                    totalPrice += 100;
                                    break;
                                }
                            case 3:
                                {
                                    totalPrice += 150;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("your choice invalid, please try again....");
                                    goto start;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("select the size of pepsi: 1 - 500ml, 2 - 1Litre, 3 - 1.5Litre");
                        int pepsi = int.Parse(Console.ReadLine());
                        switch (pepsi)
                        {
                            case 1:
                                {
                                    totalPrice += 50;
                                    break;
                                }
                            case 2:
                                {
                                    totalPrice += 100;
                                    break;
                                }
                            case 3:
                                {
                                    totalPrice += 150;
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("your choice invalid, please try again....");
                                    goto start;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("your choice invalid, please try again....");
                        goto start;
                    }
            }
            decide:
            Console.WriteLine("Do you want to order again - yes or no");
            string nextOrder=Console.ReadLine().ToLower();
            switch(nextOrder)
            {
                case "yes":
                    {
                        goto start;
                    }
                case "no":
                    {
                        Console.WriteLine("Thanks for shopping with us");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("your choice invalid, please try again....");
                        goto decide;
                    }
            }
            Console.WriteLine("TotalPrice is {0}", totalPrice);
            Console.ReadLine();
        }
    }
}
