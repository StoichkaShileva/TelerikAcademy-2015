//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{

    public static string switchP(int num)
    {
        string result = "";
        switch (num)
        {
            case 0:
                result += "zero";
                break;
            case 1:
                result +=  "one";
                break;
            case 2:
                result +=  "two";
                break;
            case 3:
                result +=  "three";
                break;
            case 4:
                result +=  "four";
                break;
            case 5:
                result +=  "five";
                break;
            case 6:
                result +=  "six";
                break;
            case 7:
                result +=  "seven";
                break;
            case 8:
                result +=  "eight";
                break;
            case 9:
                result +=  "nine";
                break;
        }
        return result;
    }
    public static string switchTen(int num)
    {
        string result = "";
        switch (num)
        {
            case 1:
                result += "ten";
                break;
            case 2:
                result += "twenty";
                break;
            case 3:
                result += "thirty";
                break;
            case 4:
                result += "fourty";
                break;
            case 5:
                result += "fifty";
                break;
            case 6:
                result += "sixty";
                break;
            case 7:
                result += "seventy";
                break;
            case 8:
                result += "eighty";
                break;
            case 9:
                result += "ninety";
                break;
        }
        return result;
    }
    public static string switchPr(int num)
    {
        string result = "";
        switch (num)
        {
            case 1:
                result += "eleven";
                break;
            case 2:
                result += "twelve";
                break;
            case 3:
                result += "threeteen";
                break;
            case 4:
                result += "fourteen";
                break;
            case 5:
                result += "fifteen";
                break;
            case 6:
                result += "sixteen";
                break;
            case 7:
                result += "seventeen";
                break;
            case 8:
                result += "eighteen";
                break;
            case 9:
                result += "nineteen";
                break;
        }
        return result;
    }

    static void Main(string[] args)
    {
        const string hunderd = "hundred";
        int num = int.Parse(Console.ReadLine());
        string numInString = num.ToString();
        if (num < 0 || num > 999)
        {
            Console.WriteLine("Error number");
        }
        else
        {
            if (num >= 0 && num <= 9)
            {
                Console.WriteLine(switchP(num));
            }
            else if (num >= 10 && num < 20)
            {
                if(num == 10)
                {
                    Console.WriteLine("{0}", switchTen(int.Parse((numInString[0].ToString()))));
                }
                else
                {
                    Console.WriteLine("{0}", switchPr(int.Parse((numInString[1].ToString()))));
                }
            }
            else if (num >= 20 && num <= 99)
            {
                if(numInString[1] != '0')
                {
                    Console.WriteLine("{0} {1}", switchTen(int.Parse(numInString[0].ToString())), switchP(int.Parse((numInString[1].ToString()))));
                }
                else
                {
                    Console.WriteLine("{0}", switchTen(int.Parse((numInString[0].ToString()))));
                }
            }
            else if (num == 100)
            {
                Console.WriteLine(hunderd);
            }
            else if (num > 100 && num <= 999)

                if (numInString[2] == '0' && numInString[1] == '0')
                {
                    Console.WriteLine("{0} {1}", switchP(int.Parse(numInString[0].ToString())), hunderd);
                }
                else if (numInString[2] == '0' && numInString[1] != '0')
                {
                    Console.WriteLine("{0} {1} and {3}", switchP(int.Parse(numInString[0].ToString())), hunderd, switchTen(int.Parse(numInString[1].ToString())));
                }
                else if (numInString[1] == '0' && numInString[2] != '0')
                {
                    Console.WriteLine("{0} {1} and {2}", switchP(int.Parse(numInString[0].ToString())), hunderd, switchP(int.Parse(numInString[2].ToString())));
                }
                else if(numInString[1] == '1')
                {
                    Console.WriteLine("{0} {1} and {2}", switchP(int.Parse(numInString[0].ToString())), hunderd, switchPr(int.Parse((numInString[2].ToString()))));
                }
                else
                {
                    Console.WriteLine("{0} {1} and {2} {3}", switchP(int.Parse(numInString[0].ToString())), hunderd, switchTen(int.Parse(numInString[1].ToString())), switchP(int.Parse(numInString[2].ToString())));

                }
            else if(num == 100)
            {
                Console.WriteLine(hunderd);
            }
        }
    }
}