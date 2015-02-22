using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Maximal_sum
{
    class MaximalSum
    {
        static void FindingThreeByThree(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    Console.Write("{0,10}", matrix[rows, columns]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            int bestSum = int.MinValue;
            for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1) - 2; columns++)
                {
                    int sum = matrix[rows, columns] + matrix[rows, columns + 1] + matrix[rows, columns + 2]

                        + matrix[rows + 1, columns] + matrix[rows + 1, columns + 1] + matrix[rows + 1, columns + 2]

                        + matrix[rows + 2, columns] + matrix[rows + 2, columns + 1] + matrix[rows + 2, columns + 2];

                    if (sum > bestSum)
                        bestSum = sum;
                }
            }
            Console.WriteLine("Max sum of the square 3 x 3 is: {0}", bestSum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ROWS: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter COLS: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("For the next {0} lines you'll have to add digits to the matrix seperated with single space! :");
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] current = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                if (current.Length != cols)
                {
                    Console.WriteLine("ERROR! You have to enter exactly {0} digits as you gave into the input!", cols);
                    return;
                }
                else
                {
                    for (int j = 0; j < current.Length; j++)
                    {
                        matrix[r, j] = current[j];
                    }
                }
            }

            if (matrix.GetLength(0) >= 3)
            {
                FindingThreeByThree(matrix);
            }
            else
            {
                Console.WriteLine("Error matrix parametars. Matrix rows have to be more than 3!");
            }
        }
    }
}
