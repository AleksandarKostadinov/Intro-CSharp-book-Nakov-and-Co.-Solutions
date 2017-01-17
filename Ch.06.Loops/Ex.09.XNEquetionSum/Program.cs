using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._09.XNEquetionSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            double sum = 1;
            double xPower = 1;
            double nFactorial = 1;

            for (int count = 1; count <= n; count++)
            {
                nFactorial *= count;
                xPower *= x;
                sum += nFactorial / xPower;
            }
            Console.WriteLine(sum);
        }
    }
}
