// See https://aka.ms/new-console-template for more information
using System;
namespace b11
{
    class program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            using(StreamReader sr = new StreamReader(@"dulieu.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    numbers.Add(int.Parse(line));
                }
            }

            using (StreamWriter writer = new StreamWriter("output.txt", true))
            {
            writer.WriteLine("D");
            }

        }
    }
}