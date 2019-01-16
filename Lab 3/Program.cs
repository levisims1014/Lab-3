using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Thank you {name}!");
            bool num = true;
        number:
            Console.WriteLine($"Enter a number between 1 and 100 {name}:");
            do
            {
                byte small = Byte.Parse(Console.ReadLine());
                if (small >= 1 && small <= 100)
                {
                    if (small % 2 == 1)
                    {
                        Console.WriteLine($"{small} and Odd, {name}");
                    }
                    else 
                    {
                        Console.WriteLine($"{small} and Even, {name}");
                        {
                            if (small >= 2 && small <= 25)
                            {
                                Console.WriteLine($"Even and less than 25, {name}");
                                {
                                    if (small >= 26 && small <= 60)
                                    {
                                        Console.WriteLine("Even");
                                        {
                                            if (small > 60)
                                            {
                                                Console.WriteLine("Even");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Odd");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    {
                    again:
                        Console.WriteLine("Do you want to continue? (y/n)");
                        string mary = Console.ReadLine().ToLower();
                        if (mary == "y")
                        {
                            num = true;
                        }
                        else if (mary == "n")
                        {
                            Console.WriteLine($"Goodbye!{name}");
                            num = false;
                        }
                        else
                        {
                            Console.WriteLine($"That is an invalid response {name}! Try again.");
                            goto again;
                        }
                    }
                }
                else if (small % 2 != 0 || small % 2 == 0 && small < 0 || small > 100)
                {
                    Console.WriteLine("This number is not between 1 and 100. Please try again!");
                    goto number;
                }
            } while (num);
        }
    }
}