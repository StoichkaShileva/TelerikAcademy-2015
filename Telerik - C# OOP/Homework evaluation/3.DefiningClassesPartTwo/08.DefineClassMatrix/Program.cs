using System;
//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

class Program
{
    static void Main()
    {
        Matrix<int> matrix = new Matrix<int>(4);
        Console.WriteLine(matrix);

        Matrix<decimal> matrix2 = new Matrix<decimal>(7);
        Console.WriteLine(matrix2);
    }
}
