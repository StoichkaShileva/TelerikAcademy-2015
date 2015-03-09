using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.Remoting.Messaging;

namespace _02.Increasing_Absolute_Differences
{
    class Program
    {
        

        static BigInteger ReturnMaxVal(BigInteger value1, BigInteger value2)
        {
            BigInteger BigIntegerestValue = value1;
            if (value1 < value2)
            {
                BigIntegerestValue = value2;
            }
            return BigIntegerestValue;
        }
        static BigInteger ReturnMinVal(BigInteger value1, BigInteger value2)
        {
            BigInteger minValue = value1;
            if (value2 < value1)
            {
                minValue = value2;
            }
            return minValue;
        }
        static bool ReturnChecked(List<string> values)
        {
            bool isGood = false;
            List<BigInteger> sequenceInts = new List<BigInteger>();
            for (int i = 1; i < values.Count; i++)
            {
                BigInteger val1 = BigInteger.Parse(values[i]);
                BigInteger val2 = BigInteger.Parse(values[i - 1]);
                BigInteger maxVal = ReturnMaxVal(val1, val2);
                BigInteger minVal = ReturnMinVal(val1, val2);
                sequenceInts.Add(maxVal - minVal);
            }
            int lastSequenceIndex = 0;
            int longestSequenceLenght = 1;
            int tempLenght = 1;

            for (int i = 1; i < sequenceInts.Count; i++)
            {
                if (sequenceInts[i] - 1 == sequenceInts[i - 1] || sequenceInts[i] == sequenceInts[i-1])
                {
                    ++tempLenght;
                    if (tempLenght > longestSequenceLenght)
                    {
                        longestSequenceLenght = tempLenght;
                        lastSequenceIndex = i;
                    }
                }
                else
                {
                    tempLenght = 1;
                }
            }

            if (longestSequenceLenght == sequenceInts.Count)
            {
                isGood = true;
            }
            else
            {
                isGood = false;
            }
            return isGood;
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<List<string>> allSequences = new List<List<string>>();
            for (int i = 0; i < t; i++)
            {
                string[] currentSequence = Console.ReadLine().Split(' ');
                allSequences.Add(currentSequence.ToList());
            }
            List<bool> checkedLists = new List<bool>();
            for (int i = 0; i < allSequences.Count; i++)
            {
                checkedLists.Add(ReturnChecked(allSequences[i]));
            }
            foreach (var checkedList in checkedLists)
            {
                Console.WriteLine(checkedList);
            }
        }
    }
}
