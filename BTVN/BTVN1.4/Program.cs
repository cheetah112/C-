// See https://aka.ms/new-console-template for more information
using System;

namespace BTVN14
{
    class program 
    {
        static void Main(String[] args)
        {
            const int rate = 23000;
            Console.Write("Enter your USD need to tranfer: ");
            int usd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your VND received: " + usd*rate);
        }
    }
}
