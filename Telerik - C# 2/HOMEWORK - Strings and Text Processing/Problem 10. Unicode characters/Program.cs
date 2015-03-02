/*Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Unicode_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();

            string final = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                final += string.Format("\\u{0:X4}", (int)str[i]);
            }
            Console.WriteLine(final);
        }

    }
}
