using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strangeLand
{
    class StrangeLand
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, long> strangeNums = new Dictionary<string, long>();
            strangeNums.Add("f", 0);
            strangeNums.Add("bIn", 1);
            strangeNums.Add("oBJEC", 2);
            strangeNums.Add("mNTRVL", 3);
            strangeNums.Add("lPVKNQ", 4);
            strangeNums.Add("pNWE", 5);
            strangeNums.Add("hT", 6);

            List<long> numsAsDecimal = new List<long>();
            long finalNum = 1;
            bool inSecondCombination = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'f' || input[i] == 'b' || input[i] == 'o' || input[i] == 'm' || input[i] == 'l' || input[i] == 'p' || input[i] == 'h')
                {
                    inSecondCombination = true;
                }
                if (inSecondCombination)
                {
                    if (input[i] == 'f')
                    {
                        i += 0;
                        numsAsDecimal.Add(strangeNums["f"]);
                        inSecondCombination = false;
                    }
                    else if (input[i] == 'b')
                    {
                        i += 2;
                        numsAsDecimal.Add(strangeNums["bIn"]);
                        inSecondCombination = false;

                    }
                    else if (input[i] == 'o')
                    {
                        i += 4;
                        numsAsDecimal.Add(strangeNums["oBJEC"]);
                        inSecondCombination = false;

                    }
                    else if (input[i] == 'm')
                    {
                        i += 6;
                        numsAsDecimal.Add(strangeNums["mNTRVL"]);
                        inSecondCombination = false;

                    }
                    else if (input[i] == 'l')
                    {
                        i += 5;
                        numsAsDecimal.Add(strangeNums["lPVKNQ"]);
                        inSecondCombination = false;

                    }
                    else if (input[i] == 'p')
                    {
                        i += 3;
                        numsAsDecimal.Add(strangeNums["pNWE"]);
                        inSecondCombination = false;

                    }
                    else if (input[i] == 'h')
                    {
                        i += 1;
                        numsAsDecimal.Add(strangeNums["hT"]);
                        inSecondCombination = false;
                    }
                }
                
            }
            List<long> finalNums = new List<long>();
            for (int i = numsAsDecimal.Count - 1, z = 0; i >= 0; i--, z++)
            {
                if(z == 0)
                {
                    finalNums.Add(numsAsDecimal[i]);

                }
                else
                {
                    finalNums.Add(numsAsDecimal[i] * (long)(Math.Pow(7, z)));
                }
            }

            Console.WriteLine(finalNums.Sum());
        }
    }
}
