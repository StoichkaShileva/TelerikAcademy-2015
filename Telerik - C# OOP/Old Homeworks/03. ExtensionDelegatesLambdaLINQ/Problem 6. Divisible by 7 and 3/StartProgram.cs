/*
 Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 */
namespace Problem_6.Divisible_by_7_and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq; 
    class StartProgram
    {
        private static IEnumerable<int> UsingLinq(List<int> input)
        {
            var result = from val in input
                where val%7 == 0 && val%3 == 0
                select val;
            return result;
        }
        static void Main(string[] args)
        {
            List<int> vals = new List<int>();
            for (int i = 1; i < 150; i++)
            {
                vals.Add(i);   
            }
            //With lambda ->
            var result = vals.Where(val => val%3 == 0 && val%7 == 0);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new string('*', 20));
            //With Linq
            var resultLinq = UsingLinq(vals);
            foreach (var i in resultLinq)
            {
                Console.WriteLine(i);
            }
        }
    }
}
