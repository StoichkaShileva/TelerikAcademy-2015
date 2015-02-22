/* 
  Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Binary_search
{
    class Program
    {
        static int BinarySearch(int[] array, int value)
        {
            int low = 0, high = array.Length - 1, middlePoint = 0;

            while (low <= high)
            {
                middlePoint = low + (high - low) / 2;
                if (value == array[middlePoint])
                {
                    return middlePoint;
                }
                else if (value < array[middlePoint])
                    high = middlePoint - 1;
                else
                    low = middlePoint + 1;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array with integers seperated with single space: ");
            int[] arr =
                Console.ReadLine()
                    .Split(new string[] {",", " "}, StringSplitOptions.None)
                    .Select(a => int.Parse(a))
                    .ToArray();
            int searchedNum = int.Parse(Console.ReadLine());
            int index = BinarySearch(arr, searchedNum);
            Console.WriteLine("Index of num {0} is {1}.", searchedNum, index);
        }
    }
}
