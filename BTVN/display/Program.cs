// See https://aka.ms/new-console-template for more information
using System;

namespace display
{
    class progarm
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("MENU");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                case 1:
                    {
                        for(int i = 0; i < 4; i++){
                            Console.WriteLine("");
                            for(int j = 0; j < 7; j++){
                                Console.Write("* ");
                            }
                        }
                    }
                break;
                case 2: 
                    Console.WriteLine("Where the conner square you need?");
                    Console.WriteLine("1. Top-Left");
                    Console.WriteLine("2. Top-Right");
                    Console.WriteLine("3. Bottom-Left");
                    Console.WriteLine("4. Bottom-Right");
                    Console.Write("Enter your choice:");
                    int choice2 = int.Parse(Console.ReadLine());
                    switch(choice2)
                        {
                            case 1: 
                            {
                                for(int i = 6; i > 0; i--){
                                    Console.WriteLine("");
                                    for(int j = 0; j < i ; j++){
                                        Console.Write("* ");
                                    }
                                }
                            }
                            break;
                            case 2:
                            {
                                for(int i = 0; i <= 6; i++){
                                    Console.WriteLine("");                                  
                                    for(int j = 0; j < i ; j++){
                                        Console.Write("  ");
                                    }
                                    for(int j = 6; j > i; j--){
                                        Console.Write(" *");
                                    }
                                }
                            }
                            break;
                            case 3:
                            {
                                for(int i = 0; i <= 6; i++){
                                    Console.WriteLine("");
                                    for(int j = 0; j < i ; j++){
                                        Console.Write("* ");
                                    }
                                }
                            }
                            break;
                            case 4:
                            {
                                for(int i = 6; i > 0; i--){
                                    Console.WriteLine("");
                                    for(int j = 0; j < i ; j++){
                                        Console.Write("  ");
                                    }
                                    for(int j = i; j < 7 ; j++){
                                        Console.Write(" *");
                                    }
                                }
                            }
                            break;
                        }
                break;
                case 3:
                    {
                        for(int i = 0; i < 7; i++){
                            Console.WriteLine("");
                            for(int j = 0; j < 7; j++){
                                Console.Write(" * ");
                            }
                        }
                    }
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
