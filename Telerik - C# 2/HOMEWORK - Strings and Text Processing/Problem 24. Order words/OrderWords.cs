/*Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_24.Order_words
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words seperated with single space: ");
            string[] words = Console.ReadLine().Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
