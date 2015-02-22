/*You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Sum_integers
{
    class SumOfIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers seperated with single space or comma: ");
            int[] arr =
                Console.ReadLine()
                    .Split(new string[] {" ", ",", ", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();
            Console.WriteLine("Sum is {0}",arr.Sum());
        }
    }
}
