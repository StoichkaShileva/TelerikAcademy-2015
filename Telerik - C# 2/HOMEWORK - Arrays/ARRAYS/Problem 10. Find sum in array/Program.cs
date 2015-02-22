/* 
 We are given an array of integers and a number S.
 Write a program to find if there exists a subset of the elements of the array that has a sum S.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Find_sum_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter int array with digits seperated with single space: ");
            int[] nums = Console.ReadLine().Split(new string[] { " ", ", ", ", " }, StringSplitOptions.RemoveEmptyEntries).Select(a => int.Parse(a)).ToArray();
            Console.WriteLine("Enter S sum: ");
            int s = int.Parse(Console.ReadLine());
            int currentSum = 0;
            bool isHaveToBreak = false;
            string sequence = "";
            for (int i = 0; i < nums.Length; i++)
            {
                if (isHaveToBreak)
                {
                    break;
                }
                else
                {
                    currentSum += nums[i];
                    sequence += nums[i].ToString() + " ";
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (currentSum < s)
                    {
                        currentSum += nums[j];
                        sequence += nums[j].ToString() + " ";
                    }
                    else if (currentSum == s)
                    {
                        isHaveToBreak = true;
                        break;
                    }
                }
            }
            if (currentSum == s)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
