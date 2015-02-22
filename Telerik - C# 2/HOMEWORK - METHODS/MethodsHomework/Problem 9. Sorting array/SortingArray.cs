/*
 Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Sorting_array
{
    class SortingArray
    {
        private static void SortAscendingAndPrint(int[] numbers)
        {
            int[] newNums = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                newNums[i] = numbers[numbers.Length - 1 - i];
            }

            PrintSortedArray(newNums);
        }

        private static void PrintSortedArray(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.Write("\n");
                }
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }

        private static void SortDescending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int maxIndex = FindMaxIndex(numbers, i);
                int temp = numbers[i];
                numbers[i] = numbers[maxIndex];
                numbers[maxIndex] = temp;
            }
        }

        static int FindMaxIndex(int[] numbers, int startIndex)
        {
            int currentMax = int.MinValue;
            int currentMaxIndex = startIndex;

            for (int i = startIndex; i < numbers.Length; i++)
            {
                if (currentMax < numbers[i])
                {
                    currentMax = numbers[i];
                    currentMaxIndex = i;
                }
            }
            return currentMaxIndex;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array of digits seperated with single space: ");
            int[] arrOfDigits =
                Console.ReadLine()
                    .Split(new string[] { " ", ", ", "," }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();
            SortAscendingAndPrint(arrOfDigits);

            
            PrintSortedArray(arrOfDigits);
            SortDescending(arrOfDigits);

        }
    }
}
