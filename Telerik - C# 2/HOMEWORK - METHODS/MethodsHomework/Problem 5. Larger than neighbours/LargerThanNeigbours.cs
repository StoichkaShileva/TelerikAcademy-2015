/* 
 Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Larger_than_neighbours
{
    class LargerThanNeigbours
    {
        static bool checkIfTheNumIsBigger(int[] arr, int num)
        {
            bool isBiggerThanNeighbours = false;
            if (arr.Length > num && arr[num] != null)
            {
                if (num - 1 >= 0 && num + 1 <= arr.Length - 1)
                {
                    if (num > arr[num - 1] && num > arr[num + 1])
                        isBiggerThanNeighbours = true;
                }
                else
                {
                    Console.WriteLine("Invalid INDEX");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Invalid INDEX");
                return false;
            }

            return isBiggerThanNeighbours;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array digits seperated with single space");
            int[] arrOfDigits =
                Console.ReadLine()
                    .Split(new string[] { " ", ", ", "," }, StringSplitOptions.None)
                    .Select(x => int.Parse(x))
                    .ToArray();
            Console.WriteLine("Enter X position: ");
            int searchedNum = int.Parse(Console.ReadLine());
            bool isBigger = checkIfTheNumIsBigger(arrOfDigits, searchedNum);
            Console.WriteLine(isBigger);
        }
    }
}
