// See https://aka.ms/new-console-template for more information
using System;
namespace countchar
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input your String: ");
            string str = Console.ReadLine();
            Console.Write("Input value you want to count: ");
            char value = char.Parse(Console.ReadLine());
            int count = countchar(str, value);
            Console.WriteLine(value + " have " + count + " time display in your string");

        }

        public static int countchar(string str, char value){
            int count = 0;
            for(int i = 0; i < str.Length; i++){
                if(str[i] == value){
                    count ++;
                }
            }
            return count;
        }
    }
}
