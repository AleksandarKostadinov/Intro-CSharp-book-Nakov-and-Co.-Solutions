﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._13_XOR_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            a ^= b;
            b ^= a;
            a ^= b;

            Console.WriteLine("a = {0} ;b = {1}",a,b);
        }
    }
}
