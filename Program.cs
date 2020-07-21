using System;
using System.Net;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name. ");
            string name = Console.ReadLine();
            string response = "y";
             
            while ((response == "y") || (response == "Y"))
            {
                Console.Write("Enter a number between 1 and 100: ");
                int answer = int.Parse(Console.ReadLine());
                
                if (answer >= 1 && answer <= 100)
                {
                    bool even = answer % 2 == 0;
                    bool odd = answer % 2 != 0;
            
                    if ((even) && (answer >= 2 && answer <= 25))
                    {
                        Console.WriteLine(name + " your answer is Even and less than 25");
                    }
                    else if ((even) && (answer >= 26 && answer <= 60))
                    {
                        Console.WriteLine(name + " your answer is Even");
                    }
                    else if ((even) && (answer > 60))
                    {
                        Console.WriteLine(name + ", " + answer + " is Even");
                    }
                    else if ((odd) && (answer > 60))
                    {
                        Console.WriteLine(name + ", " + answer + " is Odd");
                    }
                    else if (odd)
                    {
                        Console.WriteLine(name + ", " + answer + " is Odd");
                    }
                        Console.Write("Continue(y/n)? ");
                        response = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine(name + ", please use an integer between 1 and 100");
                }
                
            }
            Console.WriteLine("Good Bye.");
            
            

        }

    }
}
