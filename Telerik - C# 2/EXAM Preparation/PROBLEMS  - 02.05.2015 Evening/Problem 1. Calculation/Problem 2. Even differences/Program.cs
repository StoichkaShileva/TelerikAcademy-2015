using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Problem_2.Even_differences
{
    class Program
    {
        static BigInteger DoTheMagic(int[] digits)
        {
            BigInteger finalVal = 0;
            List<BigInteger> evenNums = new List<BigInteger>();
            for (int i = 1; i < digits.Length;)
            {
                BigInteger max = BigInteger.Max(digits[i], digits[i - 1]);
                BigInteger min = BigInteger.Min(digits[i], digits[i - 1]);
                BigInteger difference = max - min;
                if (difference%2 == 0)
                {
                    //if (i + 2 < digits.Length)
                    //{
                        i += 2;
                        evenNums.Add(difference);
                    //}
                    //else
                    //{
                    //    break;
                    //}
                }
                else
                {
                    i++;
                }
            }
            for (int i = 0; i < evenNums.Count; i++)
            {
                finalVal += evenNums[i];
            }
            return finalVal;
        }
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            BigInteger sum = DoTheMagic(digits);
            Console.WriteLine(sum);
        }
    }
}
