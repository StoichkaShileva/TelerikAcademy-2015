/* 
 Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.s
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintADeck
{
    class PrintADeck
    {
        static void Main(string[] args)
        {

            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = { "clubs", "diamonds", "hearts", "spades" };
            // Solution without the fucking switch-case
            Console.WriteLine("Without switch-case");
            for (int i = 0; i <= cards.Length - 1; i++)
            {
                for (int j = 0; j <= suits.Length - 1; j++)
                {
                    if (j == suits.Length - 1)
                    {

                        Console.Write("{0} of {1}", cards[i], suits[j]);
                    }
                    else
                    {
                        Console.Write("{0} of {1}, ", cards[i], suits[j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("With switch-case");
            // Solution with the fucking switch-case
            for (int i = 0; i <= cards.Length - 1; i++)
            {
                for (int j = 0; j <= suits.Length - 1; j++)
                {
                    if (j == suits.Length - 1)
                    {
                        switch (j)
                        {
                            case 0:
                                Console.Write("{0} of {1}", cards[i], "clubs");
                                break;
                            case 1:
                                Console.Write("{0} of {1}", cards[i], "diamonds");
                                break;
                            case 2:
                                Console.Write("{0} of {1}", cards[i], "hearts");
                                break;
                            case 3:
                                Console.Write("{0} of {1}", cards[i], "spades");
                                break;
                        }
                    }
                    else
                    {
                        switch (j)
                        {
                            case 0:
                                Console.Write("{0} of {1}, ", cards[i], "clubs");
                                break;
                            case 1:
                                Console.Write("{0} of {1}, ", cards[i], "diamonds");
                                break;
                            case 2:
                                Console.Write("{0} of {1}, ", cards[i], "hearts");
                                break;
                            case 3:
                                Console.Write("{0} of {1}, ", cards[i], "spades");
                                break;
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}