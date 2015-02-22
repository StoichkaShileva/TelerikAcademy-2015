/*Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
Use generic method (read in Internet about generic methods in C#).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Number_calculations
{
    class NumberCalculations
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
        static List<T> Sum<T>(T arr)
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
            int[] digits = Console.ReadLine().Split(new string[] { " ", ",", ", " }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
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
