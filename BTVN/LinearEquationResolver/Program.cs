// See https://aka.ms/new-console-template for more information
using System;

namespace BTVN3 
{
    class linearEquationResolver
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Giải phương trình bậc nhất:");
            Console.WriteLine("Cho phương trình 'ax + b = 0' :");
            Console.Write("Nhập a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập b:");
            double b = double.Parse(Console.ReadLine());
            if(a==0){
                if(b==0) Console.WriteLine("Phương trình có vô số nghiệm!");
                else Console.WriteLine("Phương trình vô nghiệm!");
            }
            else Console.WriteLine("Phương trình có nghiệm là: " + (-b/a));
        }
    }
}