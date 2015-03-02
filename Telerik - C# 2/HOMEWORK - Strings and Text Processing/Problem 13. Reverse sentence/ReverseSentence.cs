/*Write a program that reverses the words in given sentence.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Reverse_sentence
{
    class ReverseSentence
    {
        static string ReversingSentence(string sentence)
        {
            StringBuilder reversed = new StringBuilder();
            string[] words = sentence.Split(new string[] {"!", ".", " ", ", "}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversed.Append(words[i] + " ");
            }

            return reversed.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence to reverse: ");
            string sentence = Console.ReadLine();
            string reversed = ReversingSentence(sentence);
            Console.WriteLine(reversed);
        }
    }
}
