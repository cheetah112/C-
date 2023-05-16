// See https://aka.ms/new-console-template for more information
using System;

namespace BTVN2
{
    class program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input your birthDay(dd/MM): ");
            DateTime birthDay = DateTime.ParseExact(Console.ReadLine(),"dd/MM",null);
            DateTime toDay = DateTime.Today;
            DateTime nextYearBirthDay = new DateTime(toDay.Year+1,birthDay.Month,birthDay.Day);
            DateTime thisyearBirthDay = new DateTime(toDay.Year,birthDay.Month,birthDay.Day);
            Console.WriteLine(toDay);
            Console.WriteLine(((nextYearBirthDay-toDay).Days)%((nextYearBirthDay-thisyearBirthDay).Days));
        }
    }
}
