// See https://aka.ms/new-console-template for more information
using System;

namespace find_name
{
    class progarm
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your lenght of array: ");
            int lenArr = int.Parse(Console.ReadLine());
            string[] students = new string[lenArr];
            for(int i = 0 ; i < lenArr; i++){
                Console.Write("Enter students[" + i + "] : ");
                students[i] = Console.ReadLine();
            }
            Console.Write("Enter a name of student want to find:");
            string namestd = Console.ReadLine();
            bool isExist = false;
            for(int i = 0; i < lenArr; i++){
                if(students[i].Equals(namestd)){
                    Console.WriteLine("Position of the students in the list " + namestd + " is: " + (i + 1));
                    isExist = true;
                    break;
                }
            }
            if(!isExist){
                Console.WriteLine("Not found" + namestd + " in the list.");
            }

        }
    }
}
