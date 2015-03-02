/*We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Problem_9.Forbidden_words
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array from forbidden words seperated with single space: ");
            string[] forbiddenWords =
                Console.ReadLine().Split(new string[] {" ", ",", ", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine("Enter a text which contains some of given forbidden words: ");
            string text = Console.ReadLine();
            List<char> modifiedText = new List<char>();

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                int indexOfSearched = text.IndexOf(forbiddenWords[i]);
                if (indexOfSearched != -1)
                {
                    for (int j = indexOfSearched; j < indexOfSearched + forbiddenWords[i].Length; j++)
                    {
                        text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords.Length));
                    }
                }
            }
            Console.WriteLine(text);
        }
    }
}
