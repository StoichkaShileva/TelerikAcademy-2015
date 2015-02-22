/*
 Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_10.N_Factorial
{
    class Program
    {
        static BigInteger ReturnFactiorial(BigInteger n)
        {
            BigInteger factorial = 1;
            for (BigInteger i = n; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Factorial from [{0}] is -> {1}",i,ReturnFactiorial(i)); 
            }
        }
    }
}
