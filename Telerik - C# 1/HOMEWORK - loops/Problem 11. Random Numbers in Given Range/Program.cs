/* 
 Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Random_Numbers_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInputValid = false;
            Console.Write("Enter N (N-how many random integers will be generated): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter MIN: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter MAX: ");
            int max = int.Parse(Console.ReadLine());
            if(min < max)
            {
                isInputValid = true;
            }
            else
            {
                isInputValid = false;
            }
            while(!isInputValid)
            {
                Console.WriteLine("OOOPS, WRONG INPUT! You have to enter integers in range MIN < MAX!");
                Console.Write("Enter MIN: ");
                min = int.Parse(Console.ReadLine());
                Console.Write("Enter MAX: ");
                max = int.Parse(Console.ReadLine());
                if (min < max)
                {
                    isInputValid = true;
                }
                else
                {
                    isInputValid = false;
                }
            }
            Random r = new Random();
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                int currrentR = r.Next(min, max);
                nums[i] = currrentR;
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
