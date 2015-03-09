using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentVals = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentVals[j];
                }
            }
            //Diagonal
            int diagonalValue = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        diagonalValue += matrix[i, j];
                    }
                }
            }
            List<int> values = new List<int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentValue = 0;
                    currentValue += matrix[row, col];
                    if (col + 1 < n)
                    {
                        if (matrix[row, col + 1] - 1 == matrix[row, col])
                        {
                            currentValue += matrix[row, col + 1];
                            if (col + 2 < n)
                            {
                                if (matrix[row, col + 2] - 1 == matrix[row, col + 1])
                                {
                                    currentValue += matrix[row, col + 2];
                                    if (row + 1 < n && col + 2 < n)
                                    {
                                        if (matrix[row + 1, col + 2] - 1 == matrix[row, col + 2])
                                        {
                                            currentValue += matrix[row + 1, col + 2];
                                            if (row + 2 < n && col + 2 < n)
                                            {
                                                if (matrix[row + 2, col + 2] - 1 == matrix[row + 1, col + 2])
                                                {
                                                    currentValue += matrix[row + 2, col + 2];
                                                    if (row + 2 < n && col + 3 < n)
                                                    {
                                                        if (matrix[row + 2, col + 3] - 1 == matrix[row + 2, col + 2])
                                                        {
                                                            currentValue += matrix[row + 2, col + 3];
                                                            if (row + 2 < n && col + 4 < n)
                                                            {
                                                                if (matrix[row + 2, col + 4] - 1 == matrix[row + 2, col + 3])
                                                                {
                                                                    currentValue += matrix[row + 2, col + 4];
                                                                    values.Add(currentValue);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }

            if (values.Count != 0)
            {
                int max = int.MinValue;
                foreach (var value in values)
                {
                    if (value > max)
                    {
                        max = value;
                    }
                }
                Console.WriteLine("YES {0}", max);
            }
            else
            {
                Console.WriteLine("NO {0}", diagonalValue);
            }
        }
    }
}
