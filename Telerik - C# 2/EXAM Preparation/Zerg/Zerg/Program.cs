using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Zerg
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> names = new List<string>()
            {
                "Rawr",
                "Rrrr",
                "Hsst",
                "Ssst",
                "Grrr",
                "Rarr",
                "Mrrr",
                "Psst",
                "Uaah",
                "Uaha",
                "Zzzz",
                "Bauu",
                "Djav",
                "Myau",
                "Gruh",
            };
            List<string> inputStr = new List<string>();
            BigInteger i = 0;
            BigInteger z = 0;
            string curr = string.Empty;
            while (true)
            {
                if (i % 4 == 0 && i != 0)
                {
                    i = 0;
                    inputStr.Add(curr);
                    curr = string.Empty;
                }
                if (z == input.Length)
                    break;
                curr += input[(int)z];
                z++;
                i++;
            }
            List<string> result = new List<string>();
            for (BigInteger j = 0; j < inputStr.Count; j++)
            {
                for (BigInteger k = 0; k < names.Count; k++)
                {
                    if (inputStr[(int)j] == names[(int)k])
                    {
                        result.Add(k.ToString());
                    }
                }
            }
            BigInteger fResult = 0;
            for (BigInteger x = result.Count - 1, p = 0; x >= 0; x--, p++)
            {
                fResult += (BigInteger.Parse(result[(int)x].ToString()) * (BigInteger)Math.Pow(15, (int)p));
            }
            Console.WriteLine(fResult);
        }
    }
}
