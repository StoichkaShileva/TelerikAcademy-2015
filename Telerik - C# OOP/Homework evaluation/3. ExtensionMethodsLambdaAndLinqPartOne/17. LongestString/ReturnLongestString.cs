/*
 Problem 17. Longest string

    Write a program to return the string with maximum length from an array of strings.
    Use LINQ.

 */
namespace LongestString
{
    using System;
    using System.Linq;

    class ReturnLongestString
    {
        static void Main(string[] args)
        {
            string[] someStrings =
                                {
                                "apple",
                                "7852145",
                                "The longest string!!!",
                                "short",
                                "asdasdsafaswqe"
                                };
            var sorted =
            from strings in someStrings
            orderby strings.Length descending
            select strings;
            string longest = sorted.FirstOrDefault();
            Console.WriteLine(longest);
        }

        public static string GetLongestString(string[] input) 
        {
            var longest =
            from strings in input
            orderby strings.Length descending
            select strings;
            return longest.ToArray()[0];
        }
    }
}