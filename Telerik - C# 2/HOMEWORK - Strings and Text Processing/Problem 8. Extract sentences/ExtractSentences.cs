/*Write a program that extracts from a given text all sentences containing given word.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_8.Extract_sentences
{
    class ExtractSentences
    {
        static bool IsSentenceContainsWord(string[] sentences, int index, string word)
        {
            return Regex.Matches(sentences[index], string.Format(@"\b{0}\b", word), RegexOptions.IgnoreCase).Count != 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter string for searching: ");
            string searchedStr = Console.ReadLine();

            string curr = string.Empty;
            string[] sentences = text.Split(new string[] {"."}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = sentences[i].Trim();
            }
            List<string> finalSentences = new List<string>();
            bool isCurrentSentenceCorrect = false;

            for (int i = 0; i < sentences.Length; i++)
            {
                if (IsSentenceContainsWord(sentences, i, searchedStr))
                {
                    Console.WriteLine(sentences[i]);
                }
            }
        }
    }
}
