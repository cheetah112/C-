// See https://aka.ms/new-console-template for more information
using System;

namespace BTVN2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhập ngày tháng sinh nhật của bạn(dd/MM): ");
            DateTime birthDay = DateTime.ParseExact(Console.ReadLine(),"dd/MM",null);
            DateTime toDay = DateTime.Today;
            DateTime nextYearBirthDay = new DateTime(toDay.Year+1,birthDay.Month,birthDay.Day);
            DateTime thisyearBirthDay = new DateTime(toDay.Year,birthDay.Month,birthDay.Day);
            Console.WriteLine( "Số ngày còn lại đến ngày sinh nhật của bạn là:" + ((nextYearBirthDay-toDay).Days)%((nextYearBirthDay-thisyearBirthDay).Days));
        }
    }
}
