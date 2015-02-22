//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Binary_search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array from integers seperated with single space: ");
            int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Enter K num:");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            int index = Array.BinarySearch(arr, k);
            if (index == -1)
            {
                Console.WriteLine("No such number");
            }
            else if (index >= 0)
            {
                Console.WriteLine("Number {0} exists in the array and has index of {1}", arr[index], index);
            }
            else if (index < -1)
            {
                int realIndex = arr.Length - 1;
                Console.WriteLine("The biggest number is {0} with index of {1}", arr[realIndex], realIndex);
            }
            
        }
    }
}
