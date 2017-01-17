using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._14.DecimalToHexadecimalFloating
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
                int remainder = integral % 16;
                integral /= 16;
                if (remainder == 10)
                {
                    reversedResult += "A";
                }
                else if (remainder == 11)
                {
                    reversedResult += "B";

                }
                else if (remainder == 12)
                {
                    reversedResult += "C";

                }
                else if (remainder == 13)
                {
                    reversedResult += "D";

                }
                else if (remainder == 14)
                {
                    reversedResult += "E";

                }
                else if (remainder == 15)
                {
                    reversedResult += "F";

                }
                else
                {

                    reversedResult += remainder;
                }
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
                    mantissa *= 16;
                    int toGenerate = (int)Math.Floor(mantissa);
                    if (toGenerate == 10)
                    {
                        result += "A";
                    }
                    else if (toGenerate == 11)
                    {
                        result += "B";

                    }
                    else if (toGenerate == 12)
                    {
                        result += "C";

                    }
                    else if (toGenerate == 13)
                    {
                        result += "D";

                    }
                    else if (toGenerate == 14)
                    {
                        result += "E";

                    }
                    else if (toGenerate == 15)
                    {
                        result += "F";

                    }
                    else
                    {

                        result += toGenerate;
                    }
                    mantissa -= toGenerate;

                }
            }

            Console.Write("It's hexadecimal notation is : ");
            Console.WriteLine(result);

        }
    }
}
