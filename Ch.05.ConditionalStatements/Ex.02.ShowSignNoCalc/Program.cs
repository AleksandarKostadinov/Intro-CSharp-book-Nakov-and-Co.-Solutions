using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._02.ShowSignNoCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int negativeNUms = 0;

            if (a > 0)
            {
                negativeNUms++;
            }
            if (b > 0)
            {
                negativeNUms++;
            }
            if (c > 0)
            {
                negativeNUms++;
            }
            if (negativeNUms % 2 != 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine('-');
            }


        }
    }
}
