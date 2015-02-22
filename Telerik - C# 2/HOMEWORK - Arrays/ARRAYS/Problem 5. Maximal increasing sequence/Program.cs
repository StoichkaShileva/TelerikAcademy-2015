//Write a program that finds the maximal increasing sequence in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Maximal_increasing_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sequence: (On one line, seperated by ','): ");
            int[] arrInt = Console.ReadLine().Split(new string[] { ", ", ",", " " }, StringSplitOptions.None).Select(a => int.Parse(a)).ToArray();
            string globalCombination = "";
            string currentCombination = "";
            for (int j = 1; j < arrInt.Length; j++)
            {
                int currentResult = arrInt[j] - arrInt[j - 1];
                if (currentResult == 1)
                {
                    currentCombination += arrInt[j - 1] + " ";
                }
                else
                {
                    if (globalCombination.Length <= currentCombination.Length)
                    {
                        currentCombination += arrInt[j- 1];
                        globalCombination = currentCombination;
                        currentCombination = "";
                    }
                    currentCombination = "";

                }
                if (j == arrInt.Length - 1)
                {
                    if (globalCombination.Length <= currentCombination.Length)
                    {
                        currentCombination += arrInt[j];
                        globalCombination = currentCombination;

                    }
                }

            }
            Console.WriteLine(globalCombination);
        }
    }
}
