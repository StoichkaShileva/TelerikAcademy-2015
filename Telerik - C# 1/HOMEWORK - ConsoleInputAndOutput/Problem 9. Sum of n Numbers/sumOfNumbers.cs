//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Sum_of_n_Numbers
{
    class sumOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                nums.Add(current);
            }

            int result = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                result += nums[i];
            }
            Console.WriteLine(result);
        }
    }
}
