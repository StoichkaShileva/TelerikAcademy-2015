using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Decode_and_Decrypt
{
    class Program
    {
        static string Encrypt(string message, string cypher)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;
            if (message.Length >= cypher.Length)
            {
                char current = '';
                for (int i = 0; i < cypher.Length; i++)
                {
                    for (int j = 0; j < message.Length; j++)
                    {
                        current += (char)(cypher[i] ^ message[j]);
                    }
                }
                current += 'A';

            }
            else
            {
                for (int i = 0; i < message.Length; i++)
                {
                    for (int j = 0; j < cypher.Length; j++)
                    {
                        result += (cypher[j] ^ message[i]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

        }
    }
}
