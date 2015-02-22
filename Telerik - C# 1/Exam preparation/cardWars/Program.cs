using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numOfGames = n;
            List<string> cardsPlayerA = new List<string>();
            List<string> cardsPlayerB = new List<string>();

            Dictionary<string, int> cardNums = new Dictionary<string, int>();
            cardNums.Add("2", 10);
            cardNums.Add("3", 9);
            cardNums.Add("4", 8);
            cardNums.Add("5", 7);
            cardNums.Add("6", 6);
            cardNums.Add("7", 5);
            cardNums.Add("8", 4);
            cardNums.Add("9", 3);
            cardNums.Add("10", 2);
            cardNums.Add("A", 1);
            cardNums.Add("J", 11);
            cardNums.Add("Q", 12);
            cardNums.Add("K", 13);
            cardNums.Add("Z", 0);
            cardNums.Add("Y", 0);
            cardNums.Add("X", 0);
            long playerOnePoints = 0;
            long playerTwoPoints = 0;
            long playerAFinalScore = 0;
            long playerBFinalScore = 0;
            int firstPlayerWonGames = 0;
            int secondPlayerWonGames = 0;
            bool isCardXDrawn = false;
            for (int i = 0; i < n; i++)
            {
                cardsPlayerA.Add(Console.ReadLine().ToUpper());
                cardsPlayerA.Add(Console.ReadLine().ToUpper());
                cardsPlayerA.Add(Console.ReadLine().ToUpper());

                cardsPlayerB.Add(Console.ReadLine().ToUpper());
                cardsPlayerB.Add(Console.ReadLine().ToUpper());
                cardsPlayerB.Add(Console.ReadLine().ToUpper());
            }
            for (int i = 0; i < numOfGames; i++)
            {
                int currentStrengtPlayerA = 0;
                int currentStrengtPlayerB = 0;
                foreach (var item in cardNums)
                {
                    if (cardsPlayerA[i] == item.Key)
                    {
                        currentStrengtPlayerA += item.Value;
                    }
                    if (cardsPlayerB[i] == item.Key)
                    {
                        currentStrengtPlayerB += item.Value;
                    }
                }
                if (currentStrengtPlayerA > currentStrengtPlayerB)
                {
                    firstPlayerWonGames++;
                }
                else if (currentStrengtPlayerB > currentStrengtPlayerA)
                {
                    secondPlayerWonGames++;
                }
            }
            for (int i = 0; i < numOfGames * 3; i++)
            {
                int currentStrengtPlayerA = 0;
                int currentStrengtPlayerB = 0;
                foreach (var item in cardNums)
                {
                    bool isCardXDrawnByPlayerOne = false;
                    bool isCardXDrawnByPlayerTwo = false;
                    if (cardsPlayerA[i] == item.Key)
                    {
                        if (item.Key == "X")
                        {
                            isCardXDrawnByPlayerOne = true;
                        }
                        else if(item.Key == "Y")
                        {
                            playerAFinalScore -= 200;
                        }
                        else if(item.Key == "Z")
                        {
                            playerAFinalScore *= 2;
                        }
                        else
                        {
                            currentStrengtPlayerA += item.Value;
                        }

                    }
                    if (cardsPlayerB[i] == item.Key)
                    {
                        if (item.Key == "X")
                        {
                            isCardXDrawnByPlayerTwo = true;
                        }
                        else if (item.Key == "Y")
                        {
                            playerBFinalScore -= 200;
                        }
                        else if (item.Key == "Z")
                        {
                            playerBFinalScore *= 2;
                        }
                        else
                        {
                            currentStrengtPlayerB += item.Value;
                        }
                    }
                    if(isCardXDrawnByPlayerOne == true && isCardXDrawnByPlayerTwo == true)
                    {
                        playerAFinalScore += 50;
                        playerBFinalScore += 50;
                    }
                    else if(isCardXDrawnByPlayerOne == true && isCardXDrawnByPlayerTwo == false)
                    {
                        Console.WriteLine("X card drawn! Player one wins the match!");
                        isCardXDrawn = true;
                        break;
                    }
                    else if(isCardXDrawnByPlayerOne == false && isCardXDrawnByPlayerTwo == true)
                    {
                        Console.WriteLine("X card drawn! Player two wins the match!");
                        isCardXDrawn = true;
                        break;
                    }
                }
                playerOnePoints += currentStrengtPlayerA;
                playerTwoPoints += currentStrengtPlayerB;
            }
            if (isCardXDrawn == false)
            {
                if (playerOnePoints > playerTwoPoints)
                {
                    playerAFinalScore += playerOnePoints;
                    Console.WriteLine("First player wins!");
                    Console.WriteLine("Score: {0}", playerAFinalScore);
                    Console.WriteLine("Games won: {0}", firstPlayerWonGames);
                }
                else if (playerTwoPoints > playerOnePoints)
                {
                    playerBFinalScore += playerTwoPoints;
                    Console.WriteLine("Second player wins!");
                    Console.WriteLine("Score: {0}", playerBFinalScore);
                    Console.WriteLine("Games won: {0}", secondPlayerWonGames);
                }
                else if (playerOnePoints == playerTwoPoints)
                {
                    Console.WriteLine("It's a tie!");
                    Console.WriteLine("Score: {0}", secondPlayerWonGames);
                }
            }
        }
    }
}
