// See https://aka.ms/new-console-template for more information
using System;

namespace BTVN3 
{
    class BMI
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("TÍNH CHỈ SỐ BMI:");
            Console.Write("Nhập chiều cao/height (m): ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Nhập cân nặng/weight (kg): ");
            double weight = double.Parse(Console.ReadLine());
            double bmi = Math.Round((weight/Math.Pow(height,2)),1);
            Console.WriteLine("Chỉ số BMI của bạn là: " + bmi);
            if( bmi < 18.5) Console.WriteLine("Bạn được phân loại Underweight");
            else if( bmi < 25) Console.WriteLine("Bạn được phân loại Normal");
            else if( bmi < 30) Console.WriteLine("Bạn được phân loại Overweight");
            else Console.WriteLine("Bạn được phân loại Obese");
        }
    }
}