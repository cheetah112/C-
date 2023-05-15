// See https://aka.ms/new-console-template for more information
using System;

namespace BTVN11
{
    class Program{
        static void Main(String[] args)
        {
            float width;
            float height;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " + area);
        }
    }
}