/*Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Sub_string_in_text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sub-string that will be searched: ");
            string subStr = Console.ReadLine();
            subStr = subStr.ToLower();
            Console.WriteLine("Enter the text that sub-string will be searched in: ");
            string text = Console.ReadLine();
            text = text.ToLower();
            int repeatedTimes = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int resultOfSearching = text.IndexOf(subStr, i);
                if (resultOfSearching != -1)
                {
                    i = resultOfSearching;
                    repeatedTimes++;
                }
            }
            Console.WriteLine("[{0}] is repeated {1} times", subStr, repeatedTimes);
        }
    }
}
