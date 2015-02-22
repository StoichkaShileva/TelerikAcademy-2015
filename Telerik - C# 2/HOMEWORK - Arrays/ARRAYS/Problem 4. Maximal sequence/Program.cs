//Write a program that finds the maximal sequence of equal elements in an inputay.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sequence: (On one line, seperated by ','): ");
            int[] arrInt = Console.ReadLine().Split(new string[] { ", ", ",", " " }, StringSplitOptions.None).Select(a => int.Parse(a)).ToArray();
            int repeatedTimes = 0;
            int repeatedInt = 0;
            int currentLengthMax = 0;
            int currentRepatedNum = 0;
            for (int j = 1; j < arrInt.Length; j++)
            {
                if (arrInt[j] == arrInt[j - 1])
                {
                    ++currentLengthMax;
                    currentRepatedNum = arrInt[j];
                }
                else
                {
                    if(repeatedTimes <= currentLengthMax)
                    {
                        repeatedInt = currentRepatedNum;
                        repeatedTimes = currentLengthMax;
                        currentLengthMax = 0;
                        currentRepatedNum = 0;
                    }
                    
                }
                if(j == arrInt.Length - 1)
                {
                    if (repeatedTimes <= currentLengthMax)
                    {
                        repeatedInt = currentRepatedNum;
                        repeatedTimes = currentLengthMax;
                        currentLengthMax = 0;
                        currentRepatedNum = 0;
                    }
                }
            }
            ++repeatedTimes;
            for (int i = 0; i < repeatedTimes; i++)
            {
                string forPrint = string.Format("{0}, ", repeatedInt);
                forPrint.Trim();
                Console.Write(forPrint);
            }
        }
    }
}
