//Write a program that finds the most frequent number in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter int array digits seperated with single space: ");
            int[] input = Console.ReadLine().Split(new string[] {", ", " ", ","}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Dictionary<int, int> repeatedTimesNum = new Dictionary<int, int>();
            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = input[i];
                int currentRepeats = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if(input[j] == currentNum)
                    {
                        currentRepeats++;
                    }
                    if(j == input.Length - 1)
                    {
                        if (repeatedTimesNum.ContainsKey(currentNum))
                        {
                            repeatedTimesNum[currentNum]++;
                        }
                        else
                        {
                            repeatedTimesNum.Add(currentNum, 1);
                        }
                    }
                }
            }

            int maxVal = repeatedTimesNum.Values.Max();
            var myValue = repeatedTimesNum.FirstOrDefault(x => x.Value == maxVal).Key;
            Console.WriteLine("{0} ({1} times)", myValue, maxVal);

        }
    }
}
