// See https://aka.ms/new-console-template for more information
using System;
namespace max_of_array
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap size cua mang: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for(int i = 0; i < size; i++){
                Console.Write("Nhap so thu " + i + " : ");
                array[i] = int.Parse(Console.ReadLine());
            }
            foreach(int i in array){
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            int max = array[0];
            foreach(int i in array){
                if(i > max){
                    max = i;
                }
            }
            Console.WriteLine("So lon nhat trong mang la: " + max);
        }
    }
}
