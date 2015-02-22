//Write a method that reverses the digits of given decimal number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Reverse_number
{
    class Program
    {
        static decimal ReverseNum(decimal num)
        {
            string numAsReversed = String.Empty;
            string numAsString = num.ToString();
            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                numAsReversed += numAsString[i];
            }
            decimal asNumReversed = decimal.Parse(numAsReversed);

            return asNumReversed;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter decimal num: ");
            decimal num = decimal.Parse(Console.ReadLine());
            decimal numAsReversed = ReverseNum(num);
            Console.WriteLine(numAsReversed);
        }
    }
}
