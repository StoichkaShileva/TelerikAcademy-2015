/* 
 Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
 Use only one loop.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.CalculateNK
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int finalResult = 0;
            if(n < 100 && n > 1)
            {
                if(k < n && k > 1)
                {
                    int factorialN = 1;
                    int factorialJ = 1;
                    for (int i = n, j = k; i > 0; i--, j--)
                    {
                        factorialN *= i;
                        if(j > 1)
                        {
                            factorialJ *= j;
                        }
                    }
                    finalResult = (factorialN / factorialJ);
                }
            }
            Console.WriteLine(finalResult);
        }
    }
}
