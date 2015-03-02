using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Moving_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            StringBuilder finalExtracting = new StringBuilder();
            bool isHaveToStop = false;
            int wordsLength = 0;
            Dictionary<char, int> vals = new Dictionary<char, int>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    wordsLength++;
                }
            }
            for (int i = 0, z = 0; !isHaveToStop == true; i++)
            {
                if (finalExtracting.Length == wordsLength)
                {
                    isHaveToStop = true;
                }
                if (z + 1 <= words[i].Length)
                {
                    finalExtracting.Append((words[i][words[i].Length - (z + 1)]).ToString().ToLower());
                }
                if (i == words.Length - 1)
                {
                    i = -1;
                    z++;
                }

            }
            for (int i = 'a', z = 0; i <= 'z'; i++, z++)
            {
                vals.Add((char)i, z);
            }

            string alphabet = "abcdefghijklmnopqrstuwxyz";
            for (int i = 0; i < finalExtracting.Length; i++)
            {
                int currIndex = alphabet.IndexOf(finalExtracting[i]);
                currIndex++;
                //for (int j = 0, x = 0; j <= currIndex; j++, x++)
                //{
                //    if (x + 1 == finalExtracting.Length)
                //        x = 0;
                //    if (j + 1 == currIndex)
                //    {
                //        indexToInsert = x;
                //    }
                //}
                char temp = finalExtracting[i];
                finalExtracting.Remove(i, 1);
                int indexToInsert = currIndex + i - 1;
                while (indexToInsert > finalExtracting.Length)
                {
                    indexToInsert -= finalExtracting.Length;
                }
                finalExtracting.Insert(indexToInsert, temp);
            }

            Console.WriteLine(finalExtracting);
        }
    }
}
