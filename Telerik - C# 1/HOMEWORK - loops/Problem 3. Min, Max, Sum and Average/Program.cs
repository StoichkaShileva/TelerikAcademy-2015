/* 
 Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Min__Max__Sum_and_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            for (int i = 0; i < x; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }
            int result = 0;
            int minNum = 0;
            int maxNum = 0;
            foreach (var item in nums)
            {
                result += item;
            }
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    minNum = nums[i - 1];
                }
            }
            Console.WriteLine();
            Console.WriteLine(result);
            Console.WriteLine(minNum);
            Console.WriteLine(nums.Max());
            Console.WriteLine("{0:f2}", nums.Average());
        }
    }
}
