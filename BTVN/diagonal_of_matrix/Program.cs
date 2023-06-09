// See https://aka.ms/new-console-template for more information
using System;
namespace diagonal_of_matrix
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so dong(cot): ");
            int height = int.Parse(Console.ReadLine());            

            int[,] matrix = new int[height,height];
            for(int i = 0; i < height; i++){
                for(int j = 0; j < height; j++){
                    Console.Write("nhap phan tu [" + i + "][" + j + "] : ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;
            for(int i = 0; i < height; i++){
                for(int j = 0; j < height; j++){
                    Console.Write(matrix[i,j] + "\t");
                    if(i == j) {
                        sum = sum + matrix[i,j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Gia tri duong cheo ma tran la: " + sum);
        }
    }
}
