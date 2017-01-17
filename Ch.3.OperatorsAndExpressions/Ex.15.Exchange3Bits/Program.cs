using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._15.Exchange3Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int bit3 = (n >> 3) & 1;
            int bit24 = (n >> 24) & 1;
            n = n & (~(1 << 24)) | (bit3 << 24);
            n = n & (~(1 << 3)) | (bit24 << 3);


            int bit4 = (n >> 4) & 1;
            int bit25 = (n >> 25) & 1;
            n = n & (~(1 << 25)) | (bit4 << 25);
            n = n & (~(1 << 4)) | (bit25 << 4);

            int bit5 = (n >> 5) & 1;
            int bit26 = (n >> 26) & 1;
            n = n & (~(1 << 26)) | (bit5 << 26);
            n = n & (~(1 << 5)) | (bit26 << 5);

            Console.WriteLine(n);
        }
    }
}
