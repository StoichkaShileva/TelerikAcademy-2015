using System;
//Implement an indexer this[row, col] to access the inner matrix cells.

class Program
{
    static void Main()
    {
        try
        {
            Matrix<int> matrix = new Matrix<int>(4);
            matrix[2, 2] = 5;
            matrix[0, 1] = 2;
            matrix[3, 3] = 7;
            Console.WriteLine(matrix);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
