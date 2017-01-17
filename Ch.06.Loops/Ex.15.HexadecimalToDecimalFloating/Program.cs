using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._15.HexadecimalToDecimalFloating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hexadecimal number. The answer is the number in decimal notation.");
            var number = Console.ReadLine();
            string[] partOfnum = number.Split('.');
            double result = 0;
            string integral = partOfnum[0];
            for (int pos = 0; pos < partOfnum[0].Length; pos++)
            {
                if (integral[integral.Length - 1 - pos] == 'A')
                {
                    result += 10 * Math.Pow(16, pos);
                }
                else if (integral[integral.Length - 1 - pos] == 'B')
                {
                    result += 11 * Math.Pow(16, pos);
                }
                else if (integral[integral.Length - 1 - pos] == 'C')
                {
                    result += 12 * Math.Pow(16, pos);
                }
                else if (integral[integral.Length - 1 - pos] == 'D')
                {
                    result += 13 * Math.Pow(16, pos);
                }
                else if (integral[integral.Length - 1 - pos] == 'E')
                {
                    result += 14 * Math.Pow(16, pos);
                }
                else if (integral[integral.Length - 1 - pos] == 'F')
                {
                    result += 15 * Math.Pow(16, pos);
                }
                else
                {
                    int digit = integral[integral.Length - 1 - pos] - '0';
                    result += digit * Math.Pow(16, pos);

                }
            }

            if (partOfnum.Length > 1)
            {
                string mantissa = partOfnum[1];
                for (int pos = 1; pos <= mantissa.Length; pos++)
                {
                    if (mantissa[pos - 1] == 'A')
                    {
                        result += 10 * Math.Pow(16, -pos);

                    }
                    else if (mantissa[pos - 1] == 'B')
                    {
                        result += 11 * Math.Pow(16, -pos);
                    }
                    else if (mantissa[pos - 1] == 'C')
                    {
                        result += 12 * Math.Pow(16, -pos);
                    }
                    else if (mantissa[pos - 1] == 'D')
                    {
                        result += 13 * Math.Pow(16, -pos);
                    }
                    else if (mantissa[pos - 1] == 'E')
                    {
                        result += 14 * Math.Pow(16, -pos);
                    }
                    else if (mantissa[pos - 1] == 'F')
                    {
                        result += 15 * Math.Pow(16, -pos);
                    }
                    else
                    {
                        int manDigit = mantissa[pos - 1] - '0';
                        result += manDigit * Math.Pow(16, -pos);

                    }
                }
            }
            Console.WriteLine(result);

        }
    }
}
