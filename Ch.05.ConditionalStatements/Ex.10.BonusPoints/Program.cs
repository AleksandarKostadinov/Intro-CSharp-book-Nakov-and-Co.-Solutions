using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._10.BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 0 and 10");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 3)
            {

                n *= 10;
                Console.WriteLine(n);
            }
            else if (n >= 4 && n <= 6)
            {
                n *= 100;
                Console.WriteLine(n);

            }
            else if (n >= 7 && n <= 9)
            {
                n *= 1000;
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Number outside of range.");
            }



        }
    }
}
