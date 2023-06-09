// See https://aka.ms/new-console-template for more information
using System;
namespace change_temperature
{
    class program
    {
        public static void Main(string[] args)
        {
            int option;
            while(true)
            {
                Console.WriteLine("MENU:\n1.Fahrenheit to Celsius\n2.Celsius to Fahrenheit\n0.Exit\nChose your option: ");
                option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    FToC(); 
                    break;
                    case 2:
                    CToF();
                    break;
                    case 0:
                    Environment.Exit(0);
                    break;
                }
                
            }
        }
        public static void FToC(){
            Console.Write("Insert your degree F : ");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("Your degree C is : " + ((5.0/9)*(f-32)));
        }
        static void CToF(){
            Console.Write("Insert your degree C : ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Your degree F is : " + ((c/(5.0/9))+32));
        }
    }
}