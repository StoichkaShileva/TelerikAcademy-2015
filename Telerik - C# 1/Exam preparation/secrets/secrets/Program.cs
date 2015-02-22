using System;
using System.Numerics;
class SecretNumbers
{
    static void Main(string[] args)
    {
        string n = Console.ReadLine();
        BigInteger nAsBigBigInteger= BigInteger.Parse(n);
        BigInteger oddNum = 0;
        BigInteger evenNum = 0;
        //Loop for the ODD numbers in the sequence
        for (BigInteger i = n.Length; i > 0; i -= 2)
        {
            BigInteger num = BigInteger.Parse(n[i - 1] - '0');
            BigInteger allSum = BigInteger.Parse(num * Math.Pow((n.Length - i) + 1, 2));
            oddNum += allSum;
        }

        //Loop for the EVEN numbers in the sequnce
        for (BigInteger i = n.Length - 1; i > 0; i -= 2)
        {
            BigInteger num = n[i - 1] - '0';
            BigInteger position = (n.Length - i) + 1;
            BigInteger allNum = num * num * position;
            evenNum += allNum;
        }
        BigInteger evenAndOdd = oddNum + evenNum;
        string evenAndOddStr = evenAndOdd.ToString();

        //Alpha sequence goes here
        BigInteger r = evenAndOdd % 26;
        string alphabetLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        BigInteger firstLetter = r;
        BigInteger secondNumInSecretSum = (evenAndOddStr[evenAndOddStr.Length - 1]) - '0';
        string secret = "";
        if (evenAndOddStr[evenAndOddStr.Length - 1] == '0')
        {
            Console.WriteLine(evenAndOddStr);
            Console.WriteLine("{0} has no secret alpha-sequence", n);
        }
        else if (firstLetter + secondNumInSecretSum <= 26)
        {
            BigInteger third = firstLetter + secondNumInSecretSum;
            for (BigInteger = BigInteger.Parse(irstLetter); i < third; i++)
            {
                secret += alphabetLetters[i];
            }
            Console.WriteLine(evenAndOdd);
            Console.WriteLine(secret);
        }
        else
        {
            BigInteger third = firstLetter + secondNumInSecretSum;
            BigInteger fourth = third - 26;
            //bool stop = false;
            BigIntegerindex = 0;
            for (BigIntegeri = (int)firstLetter; i < alphabetLetters.Length; i++, index++)
            {
                secret += alphabetLetters[i];
                if (i == 25)
                {
                    i = -1;
                }
                if (index == third)
                {
                    break;
                }

                //if (third > 26 && i == (alphabetLetters.Length - 1))
                //{
                //    if (fourth < 52)
                //    {
                //        for (BigIntegerj = 0; j < fourth; j++)
                //        {
                //            secret += alphabetLetters[j];
                //        }
                //        stop = true;
                //    }

                //}

            }
            string fin = secret.Substring(0, (int)secondNumInSecretSum);
            Console.WriteLine(evenAndOdd);
            Console.WriteLine(fin);
        }
    }
}