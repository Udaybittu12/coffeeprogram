using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalcoffee = 0;
            start:
            Console.WriteLine("enter your number of coffee do you want? ");
            Console.WriteLine("1.small \n2.medium \n3.large \n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    totalcoffee += 10;
                    break;
                case 2:
                    totalcoffee += 20;
                    break;
                case 3:
                    totalcoffee += 40;
                    break;
                default:
                    Console.WriteLine("enter valid choices in the option 1 to 3" + "\n" + choice + "is the invalid choice");
                    Console.WriteLine();
                    goto start;
            }
            define:
            Console.WriteLine("do you want another coffee - yes or no ?");
            string s = Console.ReadLine().ToUpper();
            if (s != "YES" && s != "NO")
            {
                Console.WriteLine("enter valid option from the above yes or no only");
                goto define;
            }
            else if (s == "YES") { goto start; }

            Console.WriteLine("thank you for visiting coffeeshop");
            Console.WriteLine("total bill amount is:" + totalcoffee);








            /* coffee program using dowhile
            string s = string.Empty;
            int totalcoffee = 0;
            do
            {
                int choice = -1;
                do
                {
                    Console.WriteLine("enter which type of coffee do you want? ");
                    Console.WriteLine("1.small \n2.medium \n3.large \n");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            totalcoffee += 10;
                            break;
                        case 2:
                            totalcoffee += 20;
                            break;
                        case 3:
                            totalcoffee += 40;
                            break;
                        default:
                            Console.WriteLine("enter valid choices in the option 1 to 3" + "\n" + choice + "is the invalid choice");
                            Console.WriteLine();
                            break;
                    }
                } while (choice != 1 && choice != 2 && choice != 3);
                do
                {
                    Console.WriteLine("do you want another coffee - yes or no ?");
                    s = Console.ReadLine().ToUpper();
                    if (s != "YES" && s != "NO")
                    {
                        Console.WriteLine("enter valid option from the above yes or no only");
                    }

                } while (s != "YES" && s != "NO");
            } while (s.ToUpper() != "NO");
            Console.WriteLine("thank you for visiting coffeeshop");
            Console.WriteLine("total bill amount is:" + totalcoffee); */




            Console.ReadKey();
        }
    }
}
