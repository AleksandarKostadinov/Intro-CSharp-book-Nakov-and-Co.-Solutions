﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._01.HelloSomeone
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            PrintHelloSomeone(name);
        }
        static void PrintHelloSomeone(string someName)
        {
            Console.WriteLine($"Hello, {someName}!");
        }
    }
}
