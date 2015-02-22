//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Sequence_n_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ROWS for the matrix");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cols for the matrix");
            int c = int.Parse(Console.ReadLine());
            string[,] matrix = new string[r,c];
            Console.WriteLine("For the next {0} lines you'll have to add strings to the array seperated with space", r);
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] current = Console.ReadLine().Split(' ').ToArray();
                if (current.Length != c)
                {
                    Console.WriteLine("ERROR! You have to enter exactly {0} string per line as you gave into the input!", c);
                    return;
                }
                else
                {
                    for (int j = 0; j < current.Length; j++)
                    {
                        matrix[rows, j] = current[j];
                    }
                }

            }
            int currElement = 0;
            int maxElement = 0;
            string longSequence = "";

            // Horizontally search

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if ((matrix[row, col] == matrix[row, col + 1]))
                    {
                        currElement++;
                    }
                    else
                    {
                        currElement = 1;
                    }
                    if (currElement > maxElement)
                    {
                        maxElement = currElement;
                        longSequence = matrix[row, col];

                    }
                }
                currElement = 1;
            }

            // Vertically search

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if ((matrix[row, col] == matrix[row + 1, col]))
                    {
                        currElement++;
                    }
                    else
                    {
                        currElement = 1;
                    }
                    if (currElement > maxElement)
                    {
                        maxElement = currElement;
                        longSequence = matrix[row, col];

                    }
                }
                currElement = 1;
            }

            // Diagonally search

            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if ((matrix[row, col] == matrix[row + 1, col + 1]))
                {
                    currElement++;
                }
                else
                {
                    currElement = 1;
                }
                if (currElement > maxElement)
                {
                    maxElement = currElement;
                    longSequence = matrix[row, col];

                }
            }
            Console.Write("The longest sequence of equal strings is: ");
            for (int i = 0; i < maxElement; i++)
            {
                Console.Write(longSequence + ", ");
            }
        }
    }
}
