/* 
 Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            List<int> indexes = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = char.Parse(input[i].ToString().ToLower());
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == currentLetter)
                    {
                        indexes.Add(j);
                        break;
                    }
                }
            }
            Console.Write("Indexes: ");
            foreach (var VARIABLE in indexes)
            {
                Console.Write("{0} ",VARIABLE);
            }
        }
    }
}
