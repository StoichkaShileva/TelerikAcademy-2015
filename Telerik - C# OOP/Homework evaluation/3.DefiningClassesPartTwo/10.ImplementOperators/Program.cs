using System;
//Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
//Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Original matrixes:");
            Matrix<int> matrix = new Matrix<int>(4);
            matrix[2, 2] = 5;
            matrix[0, 1] = 2;
            matrix[3, 3] = 7;
            Console.WriteLine(matrix);

            Matrix<int> matrix2 = new Matrix<int>(4);
            matrix2[0, 1] = 2;
            matrix2[3, 1] = 6;
            matrix2[2, 3] = 9;
            Console.WriteLine(matrix2);

            Matrix<int> result = matrix + matrix2;
            Console.WriteLine("After addition:");
            Console.WriteLine(result);

            result = matrix - matrix2;
            Console.WriteLine("After subtraction:");
            Console.WriteLine(result);

            result = matrix * matrix2;
            Console.WriteLine("After multiplication:");
            Console.WriteLine(result);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
