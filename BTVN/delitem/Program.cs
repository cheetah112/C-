// See https://aka.ms/new-console-template for more information
using System;
namespace delitem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("INPUT ARRAY:");
            int[] arr = inputarr();
            Console.Write("Input your value need to delete:");
            int value = int.Parse(Console.ReadLine());
            int index_del = findindex(value, arr);
            if(index_del != -1){
                arr = deleteitem(index_del,arr);
            }
            Console.WriteLine("Your new Array is: ");
            foreach(int item in arr){
                Console.Write(item +"\t");
            }
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

        public static int findindex(int value, int[] arr){
            int index_value = -1;
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] == value){
                    index_value = i;
                    break;
                }
            }
            return index_value;
        }

        public static int[] deleteitem(int index_del,int[] arr){
            if(index_del != (arr.Length-1)){
                for(int i = index_del; i < (arr.Length - 1); i++){
                    arr[i] = arr[i+1];
            }
            }
            arr[arr.Length-1] = 0;
            return arr;
        }
    }
}
