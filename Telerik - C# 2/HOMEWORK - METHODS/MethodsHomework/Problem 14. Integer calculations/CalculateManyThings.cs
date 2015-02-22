/*
 *Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_14.Integer_calculations
{
    class CalculateManyThings
    {
        static int MinimumNum(int[] arr)
        {
            int minNum = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minNum)
                {
                    minNum = arr[i];
                }
            }
            return minNum;
        }
        static int MaximumNum(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static int AverageNum(int[] arr)
        {
            int averageNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                averageNum += arr[i];
            }
            averageNum /= arr.Length;
            return averageNum;
        }
        static long Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static long Product(int[] arr)
        {
            long product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter int digits seperated with single space: ");
            int[] digits = Console.ReadLine().Split(new string[] {" ", ",", ", "}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int min = MinimumNum(digits);
            int max = MaximumNum(digits);
            int average = AverageNum(digits);
            long sum = Sum(digits);
            long product = Product(digits);

            Console.WriteLine("Min num is -> {0}", arg0: min);
            Console.WriteLine("Max num is -> {0}", arg0: max);
            Console.WriteLine("Average num is -> {0}", arg0: average);
            Console.WriteLine("Sum is -> {0}", arg0: sum);
            Console.WriteLine("Prouct is -> {0}", arg0: product);
        }
    }
}
