/*
 * Write a program to return the string with maximum length from an array of strings.
***Use LINQ***
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_17.Longest_string
{
    class StartMain
    {
        private static string ReturnMaxLength(string[] arr)
        {
            var longestLength = arr.Max(str => str.Length);
            foreach (var s in arr)
            {
                if (s.Length == longestLength)
                    return s;
            }
            return null;
        }
        static void Main()
        {
            string[] strings = new string[3];
            strings[0] =
            "Yeeeeeeeh i am so close to the last task of this homework!";
            strings[1] = "IEnumerable fan blablablablabla";
            strings[2] = "Wohoooo something else";
            var longest = ReturnMaxLength(strings);
            Console.WriteLine("Longest string is with {0} characters", longest.Length);
            Console.WriteLine("Longest string -> ");
            Console.WriteLine(longest);
        }
    }
}
