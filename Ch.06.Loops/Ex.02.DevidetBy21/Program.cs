﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._02.DevidetBy21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 20; i < n; i++)
            {
                if (i % 21 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
