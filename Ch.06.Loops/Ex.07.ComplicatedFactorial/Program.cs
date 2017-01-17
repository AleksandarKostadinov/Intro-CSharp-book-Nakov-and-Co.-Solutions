using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._07.ComplicatedFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates N! * K! /((N - K)!)");
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            int[] nFactArray = new int[n];
            int[] kFactArray = new int[n];
            int[] nMinusKFactArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                nFactArray[i] = kFactArray[i] = nMinusKFactArray[i] = 1;
            }
            for (int currentNum  = 1; currentNum <= n; currentNum++)
            {
                nFactArray[currentNum -1] = currentNum;
            }
            for (int currentNum = 2; currentNum <= k; currentNum++)
            {
                kFactArray[currentNum -1] = currentNum;
            }
            for (int currentNum = 2; currentNum <= n - k; currentNum++)
            {
                nMinusKFactArray[currentNum -1] = currentNum;
            }
            for (int currentNum = 2; currentNum <= n; currentNum++)
            {
                nFactArray[currentNum -1] /= nMinusKFactArray[currentNum - 1]; 
                //Console.WriteLine(nFactArray[currentNum-1]); 
            }
            int result = 1;
            for (int currentNum = 2; currentNum <= n; currentNum++)
            {
                result = result * nFactArray[currentNum -1] * kFactArray[currentNum -1];
            }
            Console.WriteLine(result);
        }
    }
}
