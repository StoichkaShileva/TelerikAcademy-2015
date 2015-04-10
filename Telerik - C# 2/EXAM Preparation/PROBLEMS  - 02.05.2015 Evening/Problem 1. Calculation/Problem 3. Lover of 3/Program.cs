using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Lover_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = dimensions[0];
            int c = dimensions[1];
            int n = int.Parse(Console.ReadLine());
            List<string> valsStr = new List<string>();
            List<int> valsInt = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string[] current = Console.ReadLine().Split(' ');
                valsStr.Add(current[0]);
                valsInt.Add(int.Parse(current[1]));
            }

            int[,] matrix = new int[r, c];

            int old = 0;
            //Filling matrix
            for (int row = r - 1, x = 0; row >= 0; row--, x++)
            {
                old = 0;
                old += (3 * x);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = old;
                    old += 3;
                }
            }


            //Looping through matrix
            int finalResult = 0;
            int currentRow = r-1;
            int currentCol = 0;
            for (int i = 0; i < valsStr.Count; i++)
            {
                if (valsStr[i] == "UR" || valsStr[i] == "RU")
                {
                    for (int j = 0; j < valsInt[i]-1; j++)
                    {
                        int current = 0;
                        if (currentRow - 1 >= 0 && currentCol + 1 < c)
                        {
                            currentRow -= 1;
                            currentCol += 1;
                        }
                        else
                        {
                            break;
                        }
                        if (currentRow < r && currentRow >= 0 && currentCol >= 0 && currentCol < c)
                        {
                            current = matrix[currentRow, currentCol];
                            matrix[currentRow, currentCol] = 0;
                        }
                        finalResult += current;
                    }
                }
                else if (valsStr[i] == "RD" || valsStr[i] == "DR")
                {
                    for (int j = 0; j < valsInt[i]-1; j++)
                    {
                        int current = 0;
                        if (currentRow + 1 < r && currentCol + 1 < c)
                        {
                            currentRow += 1;
                            currentCol += 1;
                        }
                        else
                        {
                            break;
                        }
                        if (currentRow < r && currentRow >= 0 && currentCol >= 0 && currentCol < c)
                        {
                            current = matrix[currentRow, currentCol];
                            matrix[currentRow, currentCol] = 0;
                        }
                        finalResult += current;
                        
                    }
                }
                else if (valsStr[i] == "LU" || valsStr[i] == "UL")
                {
                    for (int j = 0; j < valsInt[i]-1; j++)
                    {
                        int current = 0;
                        if (currentRow - 1 >= 0 && currentCol - 1 >= 0)
                        {
                            currentRow -= 1;
                            currentCol -= 1;
                        }
                        else
                        {
                            break;
                        }
                        if (currentRow < r && currentRow >= 0 && currentCol >= 0 && currentCol < c)
                        {
                            current = matrix[currentRow, currentCol];
                            matrix[currentRow, currentCol] = 0;
                        }
                        finalResult += current;
                    }
                }
                else if (valsStr[i] == "DL" || valsStr[i] == "LD")
                {
                    for (int j = 0; j < valsInt[i]-1; j++)
                    {
                        int current = 0;
                        if (currentRow + 1 < r && currentCol - 1 >= 0)
                        {
                            currentRow += 1;
                            currentCol -= 1;
                        }
                        else
                        {
                            break;
                        }
                       if (currentRow < r && currentRow >= 0 && currentCol >= 0 && currentCol < c)
                        {
                            current = matrix[currentRow, currentCol];
                            matrix[currentRow, currentCol] = 0;
                        }
                        finalResult += current;
                    }
                }
            }
            Console.WriteLine(finalResult);
        }
    }
}
