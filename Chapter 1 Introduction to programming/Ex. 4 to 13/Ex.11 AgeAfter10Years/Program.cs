using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._11_AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentAge = Console.ReadLine();
            string format = "yy";

            DateTime justAge = DateTime.ParseExact(currentAge, format, null);
            var plus10Years = justAge.AddYears(10);
            Console.WriteLine(plus10Years.ToString(format));
        }
    }
}
