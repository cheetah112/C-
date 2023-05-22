// See https://aka.ms/new-console-template for more information
using System;

namespace Menu
{
    class progarm
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                case 1:
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                break;
                case 2: 
                    Console.WriteLine("Draw the square");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                break;
                case 3:
                    Console.WriteLine("Draw the rectangle");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                break;
                case 0:
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("No choice!");
                break;
                }
            } while (choice!=0);
        }
    }
}
