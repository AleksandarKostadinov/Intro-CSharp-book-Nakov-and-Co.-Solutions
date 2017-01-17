using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._09.InCircleOutOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Is point with coordinate from the input in a cicle 
            // with center {0,0} and R = 5 and out of rectangle with 
            // lower left corner {-1,1} and upper right corner {5,5}.

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((Math.Pow((Math.Pow(x, 2) + Math.Pow(y, 2)), 0.5) <= 5))
            {
                if (x < -1 || (x >= -1 && y < 1))
                {
                    Console.WriteLine("The point is in the circle and out of the rectangle.");

                }
                else
                {
                    Console.WriteLine("The point is not in the circle and out of the rectangle at the same time.");

                }
            }
            else
            {
                Console.WriteLine("The point is not in the circle and out of the rectangle at the same time.");
            }
        }
    }
}
