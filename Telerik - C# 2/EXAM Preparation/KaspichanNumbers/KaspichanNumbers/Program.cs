using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace durnakulakNumbers
{
    class DurnakulakNumbers
    {
        static string ReturnAsDecimal(BigInteger s)
        {
            string result = string.Empty;
            BigInteger finalResult = 0;
            List<BigInteger> results = new List<BigInteger>();
            List<string> vals = new List<string>();
            for (BigInteger i = 'A'; i <= 'Z'; i++)
            {
                vals.Add(((char)i).ToString());
            }
            for (BigInteger i = 'a'; i <= 'i'; i++)
            {
                string current = string.Empty;
                current += ((char)i).ToString();
                for (BigInteger j = 'A'; j <= 'Z'; j++)
                {
                    bool isHaveToBreak = false;
                    string currJ = ((char)j).ToString();
                    if (current[0] == 'i' && currJ == "V")
                    {
                        isHaveToBreak = true;
                    }
                    current += ((char)j).ToString();
                    vals.Add(current);
                    current = ((char)i).ToString();
                    if (isHaveToBreak == true)
                    {
                        break;
                    }
                }

            }

            //for (BigInteger i = 0; i < s.Count; i++)
            //{
            //    for (BigInteger j = 0; j < vals.Count; j++)
            //    {
            //        if (s[(int)i] == vals[(int)j])
            //        {
            //            results.Add(j);
            //        }
            //    }
            //}
            //for (BigInteger i = results.Count - 1, z = 0; i >= 0; i--, z++)
            //{
            //    result += (results[(int)i] * (BigInteger)Math.Pow(168, (int)z));
            //}
            //}
            if (s == 0)
            {
                result += 'A';
            }
            while (s != 0)
            {
                result = ((vals[(int)(s%256)]) + result);
                s /= 256;
            }

            return result;
        }
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            //List<string> n = new List<string>();
            //for (BigInteger i = 0; i < input.Length; i++)
            //{
            //    //if(i - 1 > 0 || i + 1 < n.Count - 1)
            //    //{
            //    if (Char.IsUpper(input[(int)i]))
            //    {
            //        n.Add(input[(int)i].ToString());
            //    }
            //    else if (Char.IsLower(input[(int)i]) && Char.IsUpper(input[(int)i + 1]))
            //    {
            //        n.Add(input[(int)i].ToString() + input[(int)i + 1].ToString());
            //        i++;
            //    }
            //    //}
            //}
            string result = ReturnAsDecimal(input);
            Console.WriteLine(result);
        }
    }
}
