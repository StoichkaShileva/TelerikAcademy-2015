//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersToN
{
    class printLoopedNumbers
    {
        static void Main(string[] args)
        {
            long x = long.MaxValue;
            for (long i = 1; i <= x; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
