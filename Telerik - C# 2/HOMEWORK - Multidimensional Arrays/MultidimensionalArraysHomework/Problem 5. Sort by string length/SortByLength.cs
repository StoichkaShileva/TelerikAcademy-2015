//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Sort_by_string_length
{
    class SortByLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter strings seperated with single space: ");
            string[] arrFromStrings = Console.ReadLine().Split(' ').ToArray();
            var sorted = arrFromStrings.OrderBy(x => x);
            foreach (var arrFromString in sorted)
            {
                Console.WriteLine(arrFromString);
            }

        }
    }
}
