/* 
 Write a program that finds the sequence of maximal sum in given array.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array int digits seperated by a single space: ");
            int[] numbers = Console.ReadLine().Split(new string[] {", ", " ", ","}, StringSplitOptions.None).Select(a => int.Parse(a)).ToArray();
            int size = numbers.Length;

            int start, end, tempStart;
            start = end = tempStart = 0;
            int maxSum = int.MinValue, sum = 0;

            for (int i = 0; i < size; i++)
            {

                sum += numbers[i];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    end = i;
                    start = tempStart;
                }
                if (sum <= 0)
                {
                    sum = 0;
                    tempStart = i + 1;
                }
            }

            //Priting loop (not used in alghoritm)
            for (int i = start; i <= end; i++)
            {
                Console.Write(numbers[i] + (i != end ? ", " : ""));
            }

            Console.WriteLine();
        }
    }
}
