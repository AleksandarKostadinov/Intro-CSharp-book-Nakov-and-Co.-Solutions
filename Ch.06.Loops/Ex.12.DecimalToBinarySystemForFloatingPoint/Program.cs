using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._12.DecimalToBinarySystemForFloatingPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //precition 0.00001
            Console.WriteLine("Enter number in decimal notation.");
            decimal number = decimal.Parse(Console.ReadLine());
            int integral = (int)number;
            decimal mantissa = number - integral;
            string reversedResult = null;
            string result = null;
            if (integral == 0)
            {
                reversedResult += 0;
            }



            while (integral > 0)
            {
                int remainder = integral % 2;
                integral /= 2;
                reversedResult += remainder;
            }
            for (int i = reversedResult.Length - 1; i >= 0; i--)
            {
                result += reversedResult[i];
            }

            if (mantissa > 0)
            {
                result += ".";
                for (int i = 0; i < 5 && mantissa > 0; i++)
                {
                    mantissa *= 2;
                    int toGenerate = (int)Math.Floor(mantissa);
                    result += toGenerate;
                    mantissa -= toGenerate;

                }
            }

            Console.Write("It's binary notation is : ");
            Console.WriteLine( result);
            
        }
    }
}
