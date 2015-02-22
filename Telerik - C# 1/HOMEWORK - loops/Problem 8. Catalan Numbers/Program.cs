using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        private static BigInteger FindPartialFactorial(uint startNumber, uint N)
        {
            BigInteger factorial = (BigInteger)startNumber;
            for (uint i = startNumber + 1; i < N + 1; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        static void Main()
        {
            BigInteger Nth_element;

            Console.Write("Please enter number N:");
            uint N = uint.Parse(Console.ReadLine());
            Nth_element = FindPartialFactorial((N + 1), (2 * N)) / FindPartialFactorial(1, N + 1);
            Console.WriteLine("The Nth element={0}", Nth_element);
        }
    }
}