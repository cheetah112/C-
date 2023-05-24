// See https://aka.ms/new-console-template for more information
using System;

namespace insert_number
{
    class progarm
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your lenght of array: ");
            int lenArr = int.Parse(Console.ReadLine());
            int[] numbers = new int[lenArr];
            for(int i = 0 ; i < lenArr; i++){
                Console.Write("Enter numbers[" + i + "] : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your array is:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter your index you want to insert: ");
            int index = int.Parse(Console.ReadLine());
            if(index >= 0 && index < numbers.Length){
                numbers[index] = number;
                Console.WriteLine("new array is : ");
                Console.WriteLine(string.Join(", ", numbers));
            }else{
                Console.WriteLine("Out of lenght!!!");
            }
        }
    }
}
