using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._02.DivisibleBy5And7
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            if (num % 5 ==0 && num % 7 == 0 && num != 0)
            {
                Console.WriteLine("The number is divisible by 5 and 7");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 5 and 7");
            }
        }
    }
}
