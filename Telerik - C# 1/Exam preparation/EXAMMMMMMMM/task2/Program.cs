using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal secret = int.Parse(Console.ReadLine());
            string code = Console.ReadLine();
            string encoded = "";
            List<decimal> nums = new List<decimal>();
            List<decimal> finalNums = new List<decimal>();
            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == '@')
                {
                    continue;
                }
                else if (Char.IsDigit(code[i]))
                {
                    decimal currentResult = 0;
                    currentResult = (((code[i]) + secret + 500));
                    decimal specialNum = decimal.Parse(String.Format("{0:0.00}", currentResult));
                    if (i % 2 == 0)
                    {
                        decimal value = currentResult / 100;
                        decimal widthDigits = decimal.Parse(String.Format("{0:f2}", value));
                        nums.Add(widthDigits);
                    }
                    else
                    {
                        nums.Add(currentResult * 100);
                    }
                }
                else if (Char.IsLetter(code[i]))
                {
                    decimal currentResult = 0;
                    currentResult = ((code[i]) * secret + 1000);
                    if (i % 2 == 0)
                    {
                        decimal value = currentResult / 100;
                        decimal widthDigits = decimal.Parse(String.Format("{0:f2}", value));
                        nums.Add(widthDigits);
                    }
                    else
                    {
                        nums.Add(currentResult * 100);
                    }
                }
                else
                {
                    decimal currentResult = 0;
                    currentResult = (code[i] - secret);
                    if (i % 2 == 0)
                    {
                        decimal value = currentResult / 100;
                        decimal widthDigits = decimal.Parse(String.Format("{0:f2}", value));
                        nums.Add(widthDigits);
                    }
                    else
                    {
                        nums.Add(currentResult * 100);
                    }
                }
            }

            for (int i = 0; i < nums.Count; i++)
            {
                
            }

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
