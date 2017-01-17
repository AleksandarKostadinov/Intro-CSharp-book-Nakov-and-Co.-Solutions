using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._13.BinaryToDecimalFloating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary number. The answer is the number in decimal notation.");
            var number = Console.ReadLine();
            string[] partOfnum = number.Split('.');
            double result = 0;
            string integral = partOfnum[0];
            for (int pos = 0; pos < partOfnum[0].Length; pos++)
            {
                int digit = integral[integral.Length - 1 - pos] - '0';
                result += digit * Math.Pow(2, pos);
            }
            double realNumber = double.Parse(number);
            if (realNumber % 1 != 0)
            {
                string mantissa = partOfnum[1];
                for (int pos = 1; pos <= mantissa.Length; pos++)
                {
                    int manDigit = mantissa[pos-1] - '0';
                    result += manDigit * Math.Pow(2, -pos);
                }
            }
            Console.WriteLine(result);
        }
    }
}
