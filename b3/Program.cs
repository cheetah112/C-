// See https://aka.ms/new-console-template for more information
using System;

namespace B3 
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int x = 0;
            for(int i = 2; i > 1; i++){
            Console.Write("Nhập số X: ");
            x = int.Parse(Console.ReadLine());
            if(x > 3) i = 0;
            }
            Console.WriteLine("số " + x +" đã lớn hơn 3");
        }
    }
}