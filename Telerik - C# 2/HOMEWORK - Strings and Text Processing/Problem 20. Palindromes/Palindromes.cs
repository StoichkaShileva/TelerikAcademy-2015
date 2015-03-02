/*Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_20.Palindromes
{
    class Palindromes
    {
        static bool IsPalindrome(string word)
        {
            return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());
        }
        static void Main()
        {
            string text = Console.ReadLine();

            MatchCollection words = Regex.Matches(text, @"\b\w+\b");

            Console.WriteLine("Palindromes:");

            foreach (var word in words)
            {
                if (IsPalindrome(word.ToString()))
                {
                    Console.WriteLine("{0}", word);
                }
            }

            Console.WriteLine();
        }

        
    }
}
