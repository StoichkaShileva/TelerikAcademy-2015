using System;
using System.Collections.Generic;

class DeCat
{
    public static int GetCharRetInt(char val)
    {
        int ret = 0;
        char[] chr = new char[]{'a','b','c','d','e','f','g','h',
                'i','j','k','l','m','n','o','p','q','r','s','t','u',
                'v','w','x','y','z'};

        for (int i = 0; i < chr.Length; i++)
        {
            if (chr[i] == val)
            {
                ret = i;
                break;
            }
        }
        return ret;

    }

    public static char GetCharFromIndex(int value)
    {
        char[] chr = new char[]{'a','b','c','d','e','f','g','h',
                'i','j','k','l','m','n','o','p','q','r','s','t','u',
                'v','w','x','y','z'};

        return chr[value];
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        List<long> lstoftwoneinputs = new List<long>();
        List<long> lstoftwoneinputsres = new List<long>();
        List<long> lstoftwsixres = new List<long>();
        List<string> lstOfRdySixStrs = new List<string>();
        List<char> lstofrdychars = new List<char>();
        List<string> lstofrdystrings = new List<string>();
        string[] inputarr;
        inputarr = input.Split(new char[0]);
        char chr;
        long numchr;

        long twonebasednumsys = 0;
        int countdown = 0;

        for (int i = 0; i < inputarr.Length; i++)
        {
            countdown = inputarr[i].Length - 1;
            for (int j = 0; j < inputarr[i].Length; j++)
            {

                chr = inputarr[i][j];
                numchr = GetCharRetInt(chr);
                twonebasednumsys += numchr;
                for (int k = 0; k < countdown; k++)
                {
                    twonebasednumsys *= 21;
                }
                lstoftwoneinputs.Add(twonebasednumsys);
                twonebasednumsys = 0;
                if (countdown == 0)
                {
                    long num = 0;
                    for (int m = 0; m < lstoftwoneinputs.Count; m++)
                    {
                        num += lstoftwoneinputs[m];
                    }
                    lstoftwoneinputsres.Add(num);
                    lstoftwoneinputs.Clear();
                }
                countdown--;

            }

        }
        long nm = lstoftwoneinputsres[0];
        for (int i = 0; i < lstoftwoneinputsres.Count; i++)
        {
            long num = lstoftwoneinputsres[i];
            //for (int j = 0; j <= num; j++)
            //{
            //    long tempnm = num % 26;
            //    lstoftwsixres.Add(tempnm);
            //    num /= 26;
            //    char a = GetCharFromIndex((int)tempnm);
            //    lstofrdychars.Add(a);
            //}
            while (num != 0)
            {
                long tempnm = num % 26;
                lstoftwsixres.Add(tempnm);
                num /= 26;
                char a = GetCharFromIndex((int)tempnm);
                lstofrdychars.Add(a);
            }
            lstofrdychars.Reverse();
            string stra = "";
            for (int k = 0; k < lstofrdychars.Count; k++)
            {
                stra += lstofrdychars[k];
            }
            lstofrdystrings.Add(stra);
            lstofrdychars.Clear();
            lstoftwsixres.Clear();
        }
        string aaa = "";
        for (int i = 0; i < lstofrdystrings.Count; i++)
        {
            aaa += lstofrdystrings[i] + " ";
        }
        Console.WriteLine(aaa);
    }
}