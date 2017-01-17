using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._07.WeightOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight.");

            double weight = double.Parse(Console.ReadLine());

            double weightOnMoon = weight * 0.17;

            Console.WriteLine("Your weight on the Moon is {0}",weightOnMoon);
        }
    }
}
