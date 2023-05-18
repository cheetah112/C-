using System;

namespace IF_else
{
    class program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Console.Write("Nhập điểm của bạn: ");
            // double mark = double.Parse(Console.ReadLine());
            // if(mark >= 8.5) Console.WriteLine("Học lực giỏi");
            // else if(mark >=7) Console.WriteLine("Học lực khá");
            // else if(mark >=5) Console.WriteLine("Học lực trung bình");
            // else if(mark >=3) Console.WriteLine("Học lực yếu");
            // else Console.WriteLine("Học lực kém");
            Console.Write("Nhập lớp của bạn: ");
            int clss = int.Parse(Console.ReadLine());
            if(clss >= 1 && clss <=5) Console.WriteLine("Bạn học cấp 1");
            else if(clss <=9) Console.WriteLine("Bạn học cấp 2");
            else if(clss <=12) Console.WriteLine("Bạn học cấp 3");
            else Console.WriteLine("Bạn học lớp khác");
        }
    }
}