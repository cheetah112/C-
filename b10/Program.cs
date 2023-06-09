// See https://aka.ms/new-console-template for more information
using System;
namespace b10
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Timthuong());
        }
        public static float Timthuong(){
            int a,b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            return (float) a/b;
        }
    }
}
