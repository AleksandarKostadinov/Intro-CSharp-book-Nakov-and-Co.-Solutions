﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool prime = true;
            BigInteger factoriel = 1;
            while (n > 1)
            {
                factoriel *= n;
                n--;
            }
            Console.WriteLine("n! = " + factoriel);
        }
    }
}
