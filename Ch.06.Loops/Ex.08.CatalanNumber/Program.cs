using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._08.CatalanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                Console.WriteLine("This program calculates the Catalan number \r\nCn = (2n)!/((n + 1)! * n!)");
                Console.Write("n = ");
                int n = int.Parse(Console.ReadLine());

                int[] doubleNFactArray = new int[2 * n];
                int[] nPlus1FactArray = new int[2 * n];
                int[] nFactArray = new int[2 * n];

                // Filling the arrays
                for (int i = 0; i < 2 * n; i++)
                {
                    doubleNFactArray[i] = nPlus1FactArray[i] = nFactArray[i] = 1;
                }

                for (int currentNum = 2; currentNum <= 2 * n; currentNum++)
                {
                    doubleNFactArray[currentNum - 1] = currentNum;
                }
                for (int currentNum = 2; currentNum <= n + 1; currentNum++)
                {
                    nPlus1FactArray[currentNum - 1] = currentNum;
                }
                for (int currentNum = 2; currentNum <= n; currentNum++)
                {
                    nFactArray[currentNum - 1] = currentNum;
                }
                // Dividing first two factorials
                for (int currentNum = 2; currentNum <= 2 * n; currentNum++)
                {
                    doubleNFactArray[currentNum - 1] /= nPlus1FactArray[currentNum - 1];
                }

                // calculating the factorials
                int doubleNresult = 1;
                int nResult = 1;
                for (int currentNum = 2; currentNum <= 2 * n; currentNum++)
                {
                    doubleNresult *= doubleNFactArray[currentNum - 1];
                    nResult *= nFactArray[currentNum - 1];
                }
                int result = doubleNresult / nResult;
                Console.WriteLine(result);
            }
            
        }
    }
}
