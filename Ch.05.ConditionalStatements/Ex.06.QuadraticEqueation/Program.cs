using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._06.QuadraticEqueation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program solves quadratic equations. a*x^2 + b*x + c = 0");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;

            if (a == 0)
            {
                Console.WriteLine("The equation is linear.");
                double x = -c / b;
                Console.WriteLine("x = {0}", x);
            }
            else if (b * b - 4 * a * c > 0)
            {
                double disriminant = Math.Sqrt(b * b - 4 * a * c);
                double x1 = (-b - disriminant) / (2 * a);
                double x2 = (-b + disriminant) / (2 * a);
                Console.WriteLine("The eqution has two roots.");
                Console.WriteLine("x1 = {0}\r\nx2 = {1}",x1 , x2);
            }
            else if (b * b - 4 * a * c == 0)
            {
                Console.WriteLine("The equation has one root.");
                double x = -b / (2 * a);
                Console.WriteLine("x = {0}", x);
            }
            else
            {
                Console.WriteLine("There is no real roots.");
            }

        }
    }
}
