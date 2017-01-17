using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._08.InCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Is point with coordinate from the input in a cicle 
            // with center {0,0} and R = 5.

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (Math.Pow( (Math.Pow(x, 2) + Math.Pow(y, 2)) , 0.5 ) <= 5)
            {
                Console.WriteLine("The point is in the circle.");
            }
            else
            {
                Console.WriteLine("The point is outside of the circle.");
            }
        }
    }
}
