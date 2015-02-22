/*
 *Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Numbers_in_Interval_Dividable
{
    class numsInInterval
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int count = 0;
            List<int> nums = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if(i % 5 == 0)
                {
                    count++;
                    nums.Add(i);
                }
            }
            Console.WriteLine("P: " + count);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
