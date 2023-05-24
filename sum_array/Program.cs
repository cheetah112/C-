// See https://aka.ms/new-console-template for more information
using System;

namespace sum_array
{
    class progarm
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your lenght of array: ");
            int lenArr = int.Parse(Console.ReadLine());
            int[] numbers = new int[lenArr];
            int sum = 0;
            for(int i = 0 ; i < lenArr; i++){
                Console.Write("Enter number[" + i + "] : ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            Console.WriteLine("Sum of array : " + sum);
        }
    }
}
