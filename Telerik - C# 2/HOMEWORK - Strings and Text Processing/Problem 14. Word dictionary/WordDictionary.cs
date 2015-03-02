/*A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Word_dictionary
{
    class WordDictionary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many word do you want to store in the dictionary: ");
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter word: ");
                string word = Console.ReadLine();
                Console.WriteLine("Enter explanation of the word: ");
                string explanation = Console.ReadLine();
                dict.Add(word, explanation);
            }

            Console.WriteLine("Enter WORD to search in dictionary if the word has explanation: ");
            string searchWordInDict = Console.ReadLine();
            foreach (var i in dict)
            {
                if (searchWordInDict == i.Key)
                {
                    Console.WriteLine("Explanation for {0} is that -> [ {1} ]", searchWordInDict, i.Value);
                }
            }

        }
    }
}
