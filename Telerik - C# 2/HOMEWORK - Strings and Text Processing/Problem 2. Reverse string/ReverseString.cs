//Write a program that reads a string, reverses it and prints the result at the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Reverse_string
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to reverse: ");
            string str = Console.ReadLine();
            char[] strAsChar = str.ToCharArray();
            Array.Reverse(strAsChar);
            str = string.Join("", strAsChar);
            Console.WriteLine(str);
        }
    }
}
