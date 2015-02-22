//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Sum_of_5_Numbers
{
    class sumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(new char[] {' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
            Console.WriteLine("The sum is {0:F2}.", numbers.Sum());
        }
    }
}
