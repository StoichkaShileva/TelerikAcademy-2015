/* 
 Write a program that finds in given array of integers a sequence of given sum S (if present).
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
            int[] nums =
                Console.ReadLine()
                    .Split(new string[] { " ", ", ", "," }, StringSplitOptions.None)
                    .Select(a => int.Parse(a))
                    .ToArray();

            Console.WriteLine("Enter S sum: ");
            int s = int.Parse(Console.ReadLine());
            int currentSum = 0;
            bool isHaveToBreak = false;
            string sequence = "";
            bool isHaveToNullable = false;
            bool isHaveToEdit = false;
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
                if (isHaveToNullable)
                {
                    currentSum = 0;
                    currentSum += nums[i];
                    sequence = string.Empty;
                    sequence += nums[i].ToString() + " ";
                }
                int lastSum = 0;
                lastSum += nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {

                    lastSum += nums[j];
                    if (lastSum < s)
                    {
                        currentSum += nums[j];
                        sequence += nums[j].ToString() + " ";
                    }
                    else if (lastSum > s)
                    {
                        isHaveToNullable = true;
                        break;
                    }
                    else if (lastSum == s)
                    {
                        currentSum += nums[j];
                        sequence += nums[j].ToString() + " ";
                        isHaveToBreak = true;
                        break;
                    }
                }
            }
            if (currentSum == s)
            {
                Console.WriteLine(sequence);
            }
            else
            {
                Console.WriteLine(currentSum);
                Console.WriteLine("There is no such a sequence");
            }
        }
    }
}
