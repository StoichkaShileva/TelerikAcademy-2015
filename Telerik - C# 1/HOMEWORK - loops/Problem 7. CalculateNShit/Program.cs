/* 
 In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.CalculateNShit
{
    class Program
    {
        static long Factorial(long n, long k)
        {
            long to = n - k;
            long result = 1;
            for (long i = to; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long finalResult = 0;
            if (n < 100 && n > 1)
            {
                if (k < n && k > 1)
                {
                    long factorialN = 1;
                    long factorialJ = 1;
                    for (long i = n, j = k; i > 0; i--, j--)
                    {
                        factorialN *= i;
                        if (j > 1)
                        {
                            factorialJ *= j;
                        }
                    }
                    finalResult = (factorialN / (factorialJ * (Factorial(n, k))));
                }
            }
            Console.WriteLine(finalResult);
        }
    }
}
