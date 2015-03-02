/*Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.String_length
{
    class StrLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string with max 20 chars: ");
            string str = Console.ReadLine();
            if (str.Length <= 20)
            {
                Console.WriteLine("{0}", str.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine("incorrect input data");
            }
        }
    }
}
