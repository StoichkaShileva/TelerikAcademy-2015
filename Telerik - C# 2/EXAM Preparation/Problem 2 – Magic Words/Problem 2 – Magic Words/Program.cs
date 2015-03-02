using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Magic_Words
{
    class Program
    {
        static int ReturnSorted(string str, int length)
        {
            int position;
            int len = length + 1;
            int strLength = str.Length;
            position = strLength%len;
            return position;
        }
        static void Main(string[] args)
        {
            int nextLines = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();
            for (int i = 0; i < nextLines; i++)
            {
                words.Add(Console.ReadLine());
            }
            for (int i = 0; i < words.Count; i++)
            {
                //int position = ReturnSorted(words[i], words.Count);
                //if (position < words.Count)
                //{
                //    string temp = words[position];
                //    words[position] = words[i];
                //    words[i] = temp;
                //}
                var word = words[i];
                var newIndex = word.Length % (nextLines + 1);
                words.Insert(newIndex, word);
                if (newIndex < 1)
                {
                    words.RemoveAt(i + 1);
                }
                else words.RemoveAt(i);
            }
            int countLengthOfAllWords = 0;
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    countLengthOfAllWords++;
                }
            }
            StringBuilder forPrinting = new StringBuilder();
            bool isHaveToBreak = false;
            List<string> blackList = new List<string>();
            //for (int i = 0; i < countLengthOfAllWords / 2 + 1; i++)
            //{
            //    for (int j = 0; j < words.Count; j++)
            //    {
            //        if (forPrinting.Length == countLengthOfAllWords)
            //        {
            //            isHaveToBreak = true;
            //        }
            //        if (j <= words[j].Length && i < words[j].Length)
            //        {
            //            forPrinting += words[j][i];
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //}
            //NIKKI'S ALGORITHM
            int maxLength = 0;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                }
            }
            for (int i = 0; i < maxLength; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length > i)
                    {
                        forPrinting.Append(word[i]);
                    }
                }
            }
            Console.WriteLine(forPrinting);
        }
    }
}
