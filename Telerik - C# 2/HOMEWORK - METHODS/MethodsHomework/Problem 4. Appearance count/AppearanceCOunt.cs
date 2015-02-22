/*
 Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.* 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Appearance_count
{
    class AppearanceCount
    {
        static int CountHowManyTimes(int[] nums, int searchedNum)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == searchedNum)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
                Console.WriteLine("Enter array digits seperated with single space");
                int[] arrOfDigits =
                    Console.ReadLine()
                        .Split(new string[] {" ", ", ", ","}, StringSplitOptions.None)
                        .Select(x => int.Parse(x))
                        .ToArray();
                Console.WriteLine("Enter X searched number: ");
                int searchedNum = int.Parse(Console.ReadLine());
            int times = CountHowManyTimes(arrOfDigits, searchedNum);
            Console.WriteLine("The num {0} is repeated {1} times in given array.", searchedNum, times);
        }
    }
}
