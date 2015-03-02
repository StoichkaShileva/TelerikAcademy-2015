/*Write a program that reads a string from the console and lists 
 * all different words in the string along with information how many times each word is found.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_22.Words_count
{
    class WordsCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            Dictionary<string, int> wordsRepeats = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!wordsRepeats.ContainsKey(words[i]))
                    wordsRepeats.Add(words[i], 0);
            }

            for (int j = 0; j < wordsRepeats.Count; j++)
            {
                var item = wordsRepeats.ElementAt(j);
                var itemKey = item.Key;
                var itemValue = item.Value;
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == itemKey)
                    {
                        wordsRepeats[itemKey] += 1;
                    }
                }
            }

            foreach (var word in wordsRepeats)
            {
                Console.WriteLine("[{0}] -> {1}", word.Key, word.Value);
            }
        }
    }
}
