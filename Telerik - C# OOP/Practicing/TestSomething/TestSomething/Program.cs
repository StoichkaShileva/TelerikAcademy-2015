using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace TestSomething
{
    class Program
    {
        static BigInteger ReturnAbsoluteDifference(BigInteger a, BigInteger b)
        {
            var maxVal = BigInteger.Max(a, b);
            var minVal = BigInteger.Min(a, b);
            BigInteger result = maxVal - minVal;
            return result;
        }
        static void Main()
        {
            BigInteger[] inputData = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
            List<BigInteger> powerOfDigits = new List<BigInteger>();
            for (BigInteger i = 1; i < inputData.Length; )
            {
                BigInteger result = ReturnAbsoluteDifference(inputData[(int)i], inputData[(int)i - 1]);
                if (result%2 == 0)
                {
                    i += 2;
                    powerOfDigits.Add(result);
                }
                else
                {
                    i += 1;
                }
            }
            BigInteger finalValue = 0;
            foreach (var powerOfDigit in powerOfDigits)
            {
                finalValue += powerOfDigit;
            }
            Console.WriteLine(finalValue);
        }
    }
}
