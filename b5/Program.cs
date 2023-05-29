// See https://aka.ms/new-console-template for more information
using System;
namespace b5
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y:");
            int y = int.Parse(Console.ReadLine());
            swap(ref x, ref y);
            Console.WriteLine("x:"+ x +" y:" + y);
        }
        private static void swap(ref int x, ref int y){
            int t = x;
            x = y;
            y = t;
        }
    }
}
