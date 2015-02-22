//Write a program that fills and prints a matrix of size (n, n) as shown below:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Fill_the_matrix
{
    class FillTheMatrix
    {
        //FIRST METHOD @@@
        static void ReturnForTheFirstPattern(int n)
        {
            int[,] matrix = new int[n, n];
            for (int row = 0, cols = 0, val = 1; cols < matrix.GetLength(0); val++)
            {
                matrix[row, cols] = val;
                if (val % n == 0)
                {
                    row = 0;
                    cols++;
                }
                else
                {
                    row++;
                }
            }
            //Printing matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        //SECOND METHOD @@@
        static void ReturnForTheSecondPattern(int n)
        {
            int[,] matrix = new int[n, n];
            bool isHaveToReturn = false;
            bool isHaveToGoDown = true;
            for (int row = 0, col = 0, val = 1; col < matrix.GetLength(0); val++)
            {
                matrix[row, col] = val;
                bool isHaveToEnter = true;
                if (isHaveToGoDown == true && row != n - 1)
                {
                    row++;
                }
                else if (isHaveToReturn == true)
                {
                    row--;
                }
                //When we reach the bottom of our matrix we have to change the values so that we can go upper again
                //TO UPPER
                if (row == matrix.GetLength(0) - 1)
                {
                    ++val;
                    matrix[row, col] = val;
                    isHaveToReturn = true;
                    isHaveToGoDown = false;
                    col++;
                    continue;
                }
                //TO DOWN
                else if (row == 0 && isHaveToEnter)
                {
                    ++val;
                    matrix[row, col] = val;
                    isHaveToReturn = false;
                    isHaveToGoDown = true;
                    col++;
                    continue;
                }

            }

            //Printing matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        //THIRD METHOD @@@
        static void ReturnForTheThirdthMethod(int n)
        {
            int[,] matrix = new int[n, n];
            for (int row = matrix.GetLength(0) - 1, index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); row--)
            {
                for (int currCol = (row >= 0 ? 0 : -row), currRow = (row >= 0 ? row : 0);
                    currCol < (matrix.GetLength(1) - (row >= 0 ? row : 0)); )
                {
                    matrix[currRow++, currCol++] = index++;
                }
            }


            //Printing matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("----- FIRST METHOD -----");
            ReturnForTheFirstPattern(n);
            Console.WriteLine();
            Console.WriteLine("----- SECOND METHOD -----");
            Console.WriteLine();
            ReturnForTheSecondPattern(n);
            Console.WriteLine();
            Console.WriteLine("----- THIRD METHOD -----");
            Console.WriteLine();
            ReturnForTheThirdthMethod(n);
        }
    }
}
