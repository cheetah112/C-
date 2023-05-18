// See https://aka.ms/new-console-template for more information
using System;

namespace BTVN3 
{
    class countNumber
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("ĐỌC SỐ THÀNH CHỮ");
            Console.Write("Mời bạn nhập số cần đọc: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Số của bạn bằng chữ là: ");
            if(number < 10) count1Number(number);
            else if (number < 100) count2Number(number);
            else if (number < 1000) count3Number(number);
            else Console.WriteLine ("Chưa đọc được số >= 1000");
        }
        public static void count1Number(int number) {
            switch (number) 
            {
                case 0: Console.Write("zero");
                break;
                case 1: Console.Write("one");
                break;
                case 2: Console.Write("two");               
                break;
                case 3: Console.Write("three");               
                break;
                case 4: Console.Write("four");               
                break;
                case 5: Console.Write("five");               
                break;
                case 6: Console.Write("six");               
                break;
                case 7: Console.Write("seven");              
                break;
                case 8: Console.Write("eight");               
                break;
                case 9: Console.Write("nine");               
                break;
            }
        }
        public static void count2Number(int number) {
            switch (number) 
            {
                case 10: Console.Write("ten");
                break;
                case 11: Console.Write("eleven");
                break;
                case 12: Console.Write("twelve");
                break;
                case 20: Console.Write("twenty");
                break;
                default:
                if(number < 30){
                    int ones = number % 10;
                    Console.Write("twenty ");
                    count1Number(ones);
                }else{
                    int ones = number % 10;
                    double ten = number / 10;
                    int tens = (int)Math.Truncate(ten);
                    switch (tens) 
                    {
                        case 3: Console.Write("thir");
                        break;
                        case 4: Console.Write("for");
                        break;
                        case 5: Console.Write("fif");
                        break;
                        default:
                        count1Number(tens);
                        break;
                    }
                    Console.Write("ty");
                    if(ones == 0) Console.Write("");
                    else{
                        Console.Write(" ");
                        count1Number(ones);
                    }
                }
                break;
            }
        }
        public static void count3Number(int number) {
          int tens = number%100;
          double hundred = number/100;
          int hundreds = (int)Math.Truncate(hundred);
          count1Number(hundreds);
          Console.Write(" hundred ");
          if(tens == 0) Console.Write("");
          else {
            Console.Write("and ");
            if(tens < 10) count1Number(tens);
            else count2Number(tens); 
          }    
        }
    }
}