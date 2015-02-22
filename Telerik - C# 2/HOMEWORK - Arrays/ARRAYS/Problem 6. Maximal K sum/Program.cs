/* 
 Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Maximal_K_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N - length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            int[] arrNums = new int[n];
            Console.WriteLine("On the next lines you'll have to enter int digits for the array: ");
            for (int i = 0; i < n; i++)
            {
                arrNums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arrNums);
            List<int> finalNums = new List<int>();
            for (int i = arrNums.Length - 1, z = 0; z < k ; i--, z++)
            {
                finalNums.Add(arrNums[i]);
            }
            int result = 0;
            foreach (var item in finalNums)
            {
                result += item;
            }
            Console.WriteLine(result);

        }
    }
}
