using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._02.CirclePerimAndAria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tihs program calculates rerimeter and aria of a circle");
            Console.WriteLine("Enter radius:");
            double r = double.Parse(Console.ReadLine());
            double perimeter = r * 2 * Math.PI;
            Console.WriteLine("Perimeter = {0:f2}", perimeter);
            double aria = r * r * Math.PI;
            Console.WriteLine("Aria = {0:f2}", aria);

        }
    }
}
