using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3_EqualToSomeAccuracy
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            decimal accuracy = decimal.Parse(Console.ReadLine());
            bool equal = Math.Abs(a - b) < accuracy;
            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
