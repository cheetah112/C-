using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace b7
{
    public class person
    {
        public string name;
        public int year;

        public person(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        public void xuat()
        {
            Console.WriteLine(name + "sinh năm" + year);
        }

    }
}