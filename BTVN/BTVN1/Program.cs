// See https://aka.ms/new-console-template for more information
using System;
namespace SystemTime
{
         public class Program
        {
            static void Main(String[] args)
            {
                DateTime localDate = DateTime.Now;
                System.Console.WriteLine("Datetime Now is: " + localDate);
                System.Console.WriteLine("Datetime Now new format is: " + String.Format("{0: dd/MM/yyyy HH:mm:ss}", localDate));
            }
        }
}