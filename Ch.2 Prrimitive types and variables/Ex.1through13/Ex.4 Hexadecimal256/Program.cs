using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4_Hexadecimal256
{
    class Program
    {
        static void Main(string[] args)
        {
            short h256= 0x100;
            short b = 2;
            byte a = (Byte)(h256/b);
            Console.WriteLine(a);
            string hexStr = "100";
            int hexNum = int.Parse(hexStr);
            Console.WriteLine(hexNum); 
        }
    }
}
