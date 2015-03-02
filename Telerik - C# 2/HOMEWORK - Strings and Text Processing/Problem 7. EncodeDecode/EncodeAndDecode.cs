/*Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.*/

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.EncodeDecode
{
    class EncodeAndDecode
    {
        static string EncodeMessage(string str, string chip)
        {
            string encoded = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                encoded += (char)(str[i] ^ chip[i]);
            }
            return encoded;
        }
        static string DecodeMessage(string str, string chip)
        {
            string decoded = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                decoded += (str[i] ^ chip[i]);
            }
            return decoded;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string do encrypt: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter chip: ");
            string chip = Console.ReadLine();
            string encoded = EncodeMessage(text, chip);
            string decoded = DecodeMessage(encoded, chip);
            Console.WriteLine("{0} encoded", encoded);
            Console.WriteLine("{0} decoded", decoded);
        }
    }
}
