using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._16.ExchageSequenceOfBits
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());



            for (int i = 0; i < k; i++)
            {
                long bit1 = (n >> p + i) & 1;
                long bit2 = (n >> q + i) & 1;
                n = n & (~(1 << q + i)) | (bit1 << q + i);
                n = n & (~(1 << p + i)) | (bit2 << p + i);
            }

            Console.WriteLine(n);
        }
    }
}
