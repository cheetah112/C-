// See https://aka.ms/new-console-template for more information
using System;
namespace max_of_matrix
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so dong: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int width = int.Parse(Console.ReadLine());

            int[,] matrix = new int[height,width];
            for(int i = 0; i < height; i++){
                for(int j = 0; j < width; j++){
                    Console.Write("nhap phan tu [" + i + "][" + j + "] : ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for(int i = 0; i < height; i++){
                for(int j = 0; j < width; j++){
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
            int max = matrix[0,0];
            for(int i = 0; i < height; i++){
                for(int j = 0; j < width; j++){
                    if(matrix[i,j] > max){
                        max = matrix[i,j];
                    }
                }
            }
            Console.WriteLine("Gia tri lon nhat cua ma tran nay la: " + max);
        }
    }
}
