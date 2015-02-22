using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FillTheMatrix
    {
        static void Asd(int a)
        {
            Console.WriteLine("Yeah i did it");
        }
        static void FirstExampleOfMatrix(int x, int n)
        {
            int[,] matrix = new int[x,n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int oldNum = row + 1;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    oldNum += 4;
                    if (col != 0)
                    {
                        matrix[row, col] = (row + 1) + oldNum;
                        
                    }
                }
            }


            //For Printing the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ",matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //int x = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());
            //FirstExampleOfMatrix(x, n);
            //string boom = "BOOM";
            //TakeThis(x, n, boom);
            int nForPrintingCoolStuff = 4;
            PrintCoolStuff(nForPrintingCoolStuff);
        }

        private static void PrintCoolStuff(int nForPrintingCoolStuff)
        {
            for (int row = 0; row < nForPrintingCoolStuff; row++)
            {
                for (int col = 1; col < row + 2; col++)
                {
                    Console.Write("{0} ", col);
                }
                Console.WriteLine();
            }
        }

        private static void TakeThis(int x, int n, string boom)
        {
            Console.WriteLine();
        }
    }
}
