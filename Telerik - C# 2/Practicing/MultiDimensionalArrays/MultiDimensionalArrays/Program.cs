using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
             //Matrix ->
            int[,] matrix = new int[5,10];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 5;
                }  
            }

            //Printing ->
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine("{0},{1} -> {2}", row,col, matrix[row,col]);   
                }
            }
        }
    }
}
