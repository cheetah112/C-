// See https://aka.ms/new-console-template for more information
using System;

namespace prime_number
{
    class progarm
    {
        public static void Main(string[] args)
        {
            Console.Write("Input your number: ");
            int number = int.Parse(Console.ReadLine());
            if( number < 2){
                Console.WriteLine("your number is not a prime number!");
            }else{
                bool check = true;
                for(int i = 2; i <= Math.Sqrt(number); i++){
                    if(number % i == 0){
                        check = false;
                        break;
                    }
                }
                if(check) Console.WriteLine("your number is a prime number !!!");
                else Console.WriteLine("your number is not a prime number!");
            }
        }
    }   
}