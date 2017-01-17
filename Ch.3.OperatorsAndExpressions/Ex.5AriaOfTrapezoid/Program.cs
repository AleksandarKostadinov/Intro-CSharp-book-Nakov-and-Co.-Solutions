using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5AriaOfTrapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first parallel side.");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second parallel side.");
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height.");
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());


            double aria = (double)((a + b) / 2 * h);

            Console.WriteLine("Aria ={0}",aria);
        }
    }
}
