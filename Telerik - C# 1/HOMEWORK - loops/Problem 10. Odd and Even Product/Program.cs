/* 
 You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Odd_and_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N integers seperated with single space:");
            string n = Console.ReadLine();
            string[] splitted = n.Split(new Char[] {' '});
            int resultOfEven = 1;
            int resultOfOdd = 1;
            for (int i = 0; i < splitted.Length; i++)
            {
                if(i % 2 == 0)
                {
                    resultOfOdd *= int.Parse(splitted[i]);
                }
                else
                {
                    resultOfEven *= int.Parse(splitted[i]);
                }
            }
            if(resultOfOdd == resultOfEven)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", resultOfOdd);
                Console.WriteLine("even_product = {0}", resultOfEven);
            }
        }
    }
}
