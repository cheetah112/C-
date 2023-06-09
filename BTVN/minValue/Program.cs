// See https://aka.ms/new-console-template for more information
using System;
namespace minValue
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] array = inputarr();
            int indexofmin = findminvalue(array);
            Console.WriteLine("Minvalue in index: "+ indexofmin +"\nMinValue is: " + array[indexofmin]);
        }
        public static int[] inputarr(){
            Console.Write("Input your size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i = 0; i < size; i++){
                Console.Write("Input your arr[" + i + "] : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        public static int findminvalue(int[] arr){
           int index = 0;
           int min = arr[0];
           for(int i = 0; i < arr.Length; i++){
            if(arr[i] < min){
                min = arr[i];
                index = i;
            }
           } 
            return index;
        }
    }
}
