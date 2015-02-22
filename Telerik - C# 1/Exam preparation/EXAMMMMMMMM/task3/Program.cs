using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEndReached = false;
            List<string> nums = new List<string>();
            while (!isEndReached)
            {
                string a = Console.ReadLine();
                if(a == "END" || a == "end")
                {
                    isEndReached = true;
                }
                else
                {
                    nums.Add(a);
                }
            }
            List<BigInteger> numsSum = new List<BigInteger>();
            List<BigInteger> numsSumSecond = new List<BigInteger>();
            BigInteger finalProductNum = 1;
            BigInteger finalProductNum2 = 1;
            for (int i = 0; i < nums.Count; i++)
            {
                if(nums.Count > 10)
                {
                    if(i < 10)
                    {
                        if (i % 2 == 0)
                        {
                            BigInteger sum = 1;
                            for (int j = 0; j < nums[i].Length; j++)
                            {
                                //Console.WriteLine(nums[i][j]);
                                BigInteger currentNum = nums[i][j] - '0';
                                if (currentNum == 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    sum *= currentNum;
                                }
                            }
                            numsSumSecond.Add(sum);
                        }
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            BigInteger sum = 1;
                            for (int j = 0; j < nums[i].Length; j++)
                            {
                                //Console.WriteLine(nums[i][j]);
                                BigInteger currentNum = nums[i][j] - '0';
                                if (currentNum == 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    sum *= currentNum;
                                }
                            }
                            numsSum.Add(sum);
                        }
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        BigInteger sum = 1;
                        for (int j = 0; j < nums[i].Length; j++)
                        {
                            //Console.WriteLine(nums[i][j]);
                            BigInteger currentNum = nums[i][j] - '0';
                            if (currentNum == 0)
                            {
                                continue;
                            }
                            else
                            {
                                sum *= currentNum;
                            }
                        }
                        numsSum.Add(sum);
                    }
                }
            }
            foreach (var item in numsSum)
            {
                finalProductNum *= item;
            }
            foreach (var item in numsSumSecond)
            {
                finalProductNum2 *= item;
            }
            if(nums.Count > 10)
            {
                Console.WriteLine(finalProductNum2);
                Console.WriteLine(finalProductNum);
            }
            else
            {
                Console.WriteLine(finalProductNum);
            }
        }
    }
}
