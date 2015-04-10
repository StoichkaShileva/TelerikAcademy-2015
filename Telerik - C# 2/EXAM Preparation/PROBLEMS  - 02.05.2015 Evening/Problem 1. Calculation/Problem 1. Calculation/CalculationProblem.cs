using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Xml.XPath;

namespace Problem_1.Calculation
{
    class CalculationProblem
    {

        static string ToTwentyThree(BigInteger result)
        {
            //string result = string.Empty;
            //string alphabet = "abcdefghijklmnopqrstuwxyz";
            //while (num > 0)
            //{
            //    BigInteger current = num % 23;
            //    result += alphabet[(int)current];
            //    num /= 23;
            //}
            //char[] reversed = result.ToCharArray();
            //Array.Reverse(reversed);
            //return new string(reversed);
            string resultStr = string.Empty;
            if (result == 0)
            {
                resultStr = "a";
            }

            while (result > 0)
            {
                char ch = (char)((result % 23) + 'a');
                resultStr = ch.ToString() + resultStr;
                result /= 23;
            }

            return resultStr;
        }

        static BigInteger ToBigInteger(string str)
        {
            //BigInteger result = 0;
            //string alphabet = "ABCDEFGHIJKLMNOPQRSTUW".ToLower();
            //List<BigInteger> values = new List<BigInteger>();
            //for (BigInteger i = 0; i < str.Length; i++)
            //{
            //    values.Add(alphabet.IndexOf(str[(int)i]));
            //}

            //for (BigInteger i = values.Count - 1, z = 0; i >= 0; i--, z++)
            //{
            //    result += (values[(int)i] * BigInteger.Pow(23, (int)z));
            //}
            //return result;
            BigInteger num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                BigInteger digit = str[str.Length - 1 - i] - 'a';
                num += digit * (int)BigInteger.Pow(23, i);
            }

            return num;
        }

        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            List<BigInteger> sums = new List<BigInteger>();
            for (BigInteger i = 0; i < words.Length; i++)
            {
                BigInteger currentNum = ToBigInteger(words[(int)i]);
                sums.Add(currentNum);
            }
            BigInteger final = 0;
            for (BigInteger i = 0; i < sums.Count; i++)
            {
                final += sums[(int)i];
            }
            string finalResult = ToTwentyThree(final);
            Console.WriteLine(finalResult + " = " + final);
        }
    }
}
