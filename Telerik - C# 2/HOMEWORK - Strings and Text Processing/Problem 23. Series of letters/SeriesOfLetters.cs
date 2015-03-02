using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_23.Series_of_letters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string with repeated letters:");
            string text = Console.ReadLine();
            List<char> result = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if(i + 1 < text.Length && text[i+1] != text[i])
                    result.Add(text[i]);
                else 
                    if (i + 1 == text.Length)
                        result.Add(text[i]);

            }

            foreach (var letter in result)
            {
                Console.Write(letter);
            }
        }
    }
}
