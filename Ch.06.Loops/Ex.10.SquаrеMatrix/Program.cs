using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._10.SquаrеMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = int.Parse(Console.ReadLine());

            for (int row = 1; row <= parameter; row++)
            {
                for (int colomn = 0; colomn < parameter; colomn++)
                {
                    Console.Write("{0,2} ",row + colomn );
                }
                Console.WriteLine();
            }
        }
    }
}
