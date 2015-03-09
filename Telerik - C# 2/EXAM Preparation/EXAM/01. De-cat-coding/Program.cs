//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ system).
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security;

namespace Problem_7.One_system_to_any_other
{
    class OneSystemToAnyOther
    {
        static char DecryptToShit(int val)
        {
            int result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
            char letter = alphabet[val];
            return letter;
        }
        static int Decrypt(char val)
        {
            int result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
            int index = alphabet.IndexOf(val);
            return index;
        }
        static string DecryptTo26(BigInteger asDecimal)
        {
            string result = string.Empty;
            while (asDecimal != 0)
            {
                BigInteger curr = asDecimal%26;
                char currentChar = DecryptToShit((int)curr);
                result += currentChar;
                asDecimal /= 26;
            }
            char[] strAsCharArr = result.ToCharArray();
            Array.Reverse(strAsCharArr);
            return new string(strAsCharArr);
        }

        static BigInteger ToDecimal(string input)
        {
            BigInteger result = 0;
            for (int i = input.Length - 1, z = 0; i >= 0; i--, z++)
            {
                int decrypted = Decrypt(input[i]);
                result += (decrypted * BigInteger.Pow(21, z));
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<string> final = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                BigInteger asDecimal = ToDecimal(input[i]);
                string asShit = DecryptTo26(asDecimal);
                final.Add(asShit);
            }
            for (int i = 0; i < final.Count; i++)
            {
                if (i == final.Count - 1)
                {
                    Console.Write("{0}", final[i]);
                }
                else
                {
                    Console.Write("{0} ", final[i]);
                }
            }
        }
    }
}
