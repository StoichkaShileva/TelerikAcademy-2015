using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Resources;
using System.Security.Cryptography.X509Certificates;

namespace firstTask
{
    class from19To10AndBack
    {
        static BigInteger ToDecimal(string num)
        {
            BigInteger finalValue = 0;
            switch (num)
            {
                case "aaa":
                    finalValue += 1;
                    break;
                case "bbb":
                    finalValue += 2;
                    break;
                case "ccc":
                    finalValue += 3;
                    break;
                case "ddd":
                    finalValue += 4;
                    break;
                case "eee":
                    finalValue += 5;
                    break;
                case "fff":
                    finalValue += 6;
                    break;
                case "xxx":
                    finalValue += 7;
                    break;
                case "zzz":
                    finalValue += 8;
                    break;
                case "mmm":
                    finalValue += 9;
                    break;
                case "nnn":
                    finalValue += 10;
                    break;
                case "lll":
                    finalValue += 11;
                    break;
                case "ooo":
                    finalValue += 12;
                    break;
                case "kkk":
                    finalValue += 13;
                    break;
                case "iii":
                    finalValue += 14;
                    break;
                case "jjj":
                    finalValue += 15;
                    break;
                case "rrr":
                    finalValue += 16;
                    break;
                case "qqq":
                    finalValue += 17;
                    break;
                case "uuu":
                    finalValue += 18;
                    break;
                case "yyy":
                    finalValue += 19;
                    break;
            }
            return finalValue;
        }

        static string ToNineth(int num)
        {
            string value = string.Empty;
            int numAsRightThing = num;
            List<int> reminder = new List<int>();
            while (numAsRightThing >= 0)
            {
                if (numAsRightThing/19 > 0 && numAsRightThing > 19)
                {
                    reminder.Add(numAsRightThing%19);
                    numAsRightThing /= 19;
                }
                else if (numAsRightThing <= 19)
                {
                    reminder.Add(numAsRightThing % 19);
                    numAsRightThing /= 19;
                    break;
                }
            }
            reminder.Reverse();
            for (int i = 0; i < reminder.Count; i++)
            {
                value += ReturnSpecialValue(reminder[i]);
            }
            
            return value;
        }

        private static string ReturnSpecialValue(int reminder)
        {
            string value = string.Empty;
            switch (reminder)
            {
                case 1:
                    value += "aaa";
                    break;
                case 2:
                    value += "bbb";
                    break;
                case 3:
                    value += "ccc";
                    break;
                case 4:
                    value += "ddd";
                    break;
                case 5:
                    value += "eee";
                    break;
                case 6:
                    value += "fff";
                    break;
                case 7:
                    value += "xxx";
                    break;
                case 8:
                    value += "zzz";
                    break;
                case 9:
                    value += "mmm";
                    break;
                case 10:
                    value += "nnn";
                    break;
                case 11:
                    value += "lll";
                    break;
                case 12:
                    value += "ooo";
                    break;
                case 13:
                    value += "kkk";
                    break;
                case 14:
                    value += "iii";
                    break;
                case 15:
                    value += "jjj";
                    break;
                case 16:
                    value += "rrr";
                    break;
                case 17:
                    value += "qqq";
                    break;
                case 18:
                    value += "uuu";
                    break;
                case 19:
                    value += "yyy";
                    break;
            }
            return value;
        }

        static void Main(string[] args)
        {
            string[] numsInNineth = Console.ReadLine().Split(' ');
            List<BigInteger> numsIntDecimal =  new List<BigInteger>();
            for (int i = 0; i < numsInNineth.Length; i++)
            {
                numsIntDecimal.Add(ToDecimal(numsInNineth[i]));
            }
            for (int i = 0; i < numsIntDecimal.Count; i++)
            {
                numsIntDecimal[i] *= 5;
            }
            List<string> finalInNinth = new List<string>();
            for (int i = 0; i < numsIntDecimal.Count; i++)
            {
                finalInNinth.Add(ToNineth((int)numsIntDecimal[i]));
            }

            foreach (var bigInteger in numsIntDecimal)
            {
                Console.WriteLine(bigInteger);
            }
            foreach (var e in finalInNinth)
            {
                Console.WriteLine(e);
            }
        }
    }
}
