/*
 Problem 8. Matrix

Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
Problem 9. Matrix indexer

Implement an indexer this[row, col] to access the inner matrix cells.
Problem 10. Matrix operations

Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
Throw an exception when the operation cannot be performed.
Implement the true operator (check for non-zero elements).
 */
namespace Matrix
{
    using System;
    class MatrixSolver
    {
        static void Main()
        {
            Matrix<double> matrix = new Matrix<double>(3, 1);
            matrix[0, 0] = 20;
            matrix[1, 0] = 553.3;
            matrix[2, 0] = 2222;
            Matrix<double> matrix2 = new Matrix<double>(3, 2);
            matrix2[0, 0] = 100;
            matrix2[1, 0] = 10;

            Matrix<int> matrix3 = new Matrix<int>(2,2);
            matrix3[0, 0] = 550000;
            matrix3[1, 0] = 20000333;
            matrix3[0, 1] = 1;
            matrix3[1, 1] = 3333333;

            Matrix<int> matrix4 = new Matrix<int>(2, 2);
            matrix4[0, 0] = 12345;
            matrix4[1, 0] = 54321;
            matrix4[0, 1] = 785645342;
            matrix4[1, 1] = 987654321;

            Console.WriteLine("Matrix 3 has {0} rows and {1} cols", matrix3.Rows, matrix3.Cols);

            Matrix<int> matrix5 = matrix3 + matrix4;

            Matrix<int> matrix6 = matrix3 - matrix4;

            Matrix<int> matrix7 = matrix3 * matrix4;




            Console.WriteLine(new string('@', 20));
            Console.WriteLine("---- Matrices addition: ");
            Console.WriteLine();
            for (int row = 0; row < matrix5.Rows; row++)
            {
                for (int col = 0; col < matrix5.Cols; col++)
                {
                    Console.WriteLine("Matrix 3 addited with matrix 4 values -> {0}", matrix5[row, col]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('@', 20));


            Console.WriteLine(new string('@', 20));
            Console.WriteLine("---- Matrices substraction: ");
            Console.WriteLine();
            for (int row = 0; row < matrix6.Rows; row++)
            {
                for (int col = 0; col < matrix6.Cols; col++)
                {
                    Console.WriteLine("Matrix 3 substracted with matrix 4 values -> {0}", matrix6[row, col]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('@', 20));

            Console.WriteLine(new string('@', 20));
            Console.WriteLine("---- Matrices multiplication: ");
            Console.WriteLine();
            for (int row = 0; row < matrix7.Rows; row++)
            {
                for (int col = 0; col < matrix7.Cols; col++)
                {
                    Console.WriteLine("Matrix 3 multiplied by matrix 4 values -> {0}", matrix7[row,col]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('@', 20));
            if (matrix)
            {

                Console.WriteLine("Matrix 1 contains zero elements!");   
            }
            else
            {
               Console.WriteLine("Matrix 1 does not contain any zero elements!");
            }
        }
    }
}
