using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._10.ABCD_4DigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four digit number");
            string num = Console.ReadLine();

            char A = num[0];
            char B = num[1];
            char C = num[2];
            char D = num[3];

            int sum = A + B + C + D - 4 * '0';
            Console.WriteLine("SUM  = {0}", sum);

            Console.WriteLine("DCBA = {3}{2}{1}{0}", A, B, C, D);
            Console.WriteLine("DABC = {3}{0}{1}{2}", A, B, C, D);
            Console.WriteLine("ACBD = {0}{2}{1}{3}", A, B, C, D);

        }
    }
}
