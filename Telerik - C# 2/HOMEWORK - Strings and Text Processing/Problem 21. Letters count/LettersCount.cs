/*Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_21.Letters_count
{
    class LettersCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                    if (!letters.ContainsKey(text[i]))
                        letters.Add(text[i], 0);
            }

            for (int j = 0; j < letters.Count; j++)
            {
                var item = letters.ElementAt(j);
                var itemKey = item.Key;
                var itemValue = item.Value;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == itemKey)
                    {
                        letters[itemKey] += 1;
                    }
                }
            }

            foreach (var letter in letters)
            {
                Console.WriteLine("[{0}] -> {1}", letter.Key, letter.Value);
            }
        }
    }
}
