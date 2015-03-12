namespace Matrix
{
    using System;
    using System.Collections.Generic;
    public class Matrix<T> where T : IComparable
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rowsInput, int colsInput)
        {
            this.Rows = rowsInput;
            this.Cols = colsInput;
            matrix = new T[rows, cols];
        }

        public int Rows
        {
            get { return this.rows; }
            set
            {
                if (value > 0 && value < int.MaxValue)
                    rows = value;
                else
                {
                    throw new ArgumentException("Rows cant be negative or more than int.MaxValue!");
                }
            }
        }

        public int Cols
        {
            get { return this.cols; }
            set
            {
                if (value > 0 && value < int.MaxValue)
                    cols = value;
                else
                {
                    throw new ArgumentException("Cols cant be negative or more than int.MaxValue!");
                }
            }
        }

        public T this[int rowsInput, int colsInput]
        {
            get { return matrix[rowsInput, colsInput]; }
            set
            {
                if (rowsInput >= 0 && rowsInput <= int.MaxValue && colsInput >= 0 && colsInput <= int.MaxValue)
                {
                    matrix[rowsInput, colsInput] = value;
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new ArgumentException("Matrices must be with the same length ot rows and cols!");
            }
            int currentRows = m1.Rows;
            int currentCols = m1.Cols;
            Matrix<T> current = new Matrix<T>(currentRows, currentCols);
            for (int i = 0; i < current.Rows; i++)
            {
                for (int j = 0; j < current.Cols; j++)
                {
                    dynamic m1CurrentVal = m1[i, j];
                    dynamic m2CurrentVal = m2[i, j];
                    current[i, j] = m1CurrentVal + m2CurrentVal;
                }
            }
            return current;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new ArgumentException("Matrices must be with the same length ot rows and cols!");
            }
            int currentRows = m1.Rows;
            int currentCols = m1.Cols;
            Matrix<T> current = new Matrix<T>(currentRows, currentCols);
            for (int i = 0; i < current.Rows; i++)
            {
                for (int j = 0; j < current.Cols; j++)
                {
                    dynamic m1CurrentVal = m1[i, j];
                    dynamic m2CurrentVal = m2[i, j];
                    current[i, j] = m1CurrentVal - m2CurrentVal;
                }
            }
            return current;
        }


        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new ArgumentException("Matrices must be with the same length ot rows and cols!");
            }
            T val;
            int currentRows = m1.Rows;
            int currentCols = m1.Cols;
            Matrix<T> current = new Matrix<T>(currentRows, currentCols);
            for (int i = 0; i < current.Rows; i++)
            {
                for (int j = 0; j < current.Cols; j++)
                {
                    val = (dynamic)0;
                    for (int k = 0; k < current.Cols; k++)
                    {
                        dynamic m1CurrentVal = m1[i, k];
                        dynamic m2CurrentVal = m2[i, j];
                        val += m1CurrentVal * m2CurrentVal;
                    }
                    current[i, j] = (dynamic)val;

                }
            }
            return current;
        }

        public static bool operator true(Matrix<T> m1)
        {
            bool doesContainZeroElements = false;
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    if (m1[i, j].Equals(default(T)))
                    {
                        doesContainZeroElements = true;
                        break;
                    }
                }
            }
            return doesContainZeroElements;
        }
        public static bool operator false(Matrix<T> m1)
        {
            bool doesContainZeroElements = true;
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    if (m1[i, j].Equals(default(T)))
                    {
                        doesContainZeroElements = false;
                    }
                    else
                    {
                        doesContainZeroElements = true;
                    }
                }
            }
            return doesContainZeroElements;
        }

        public override string ToString()
        {
            return this.ToString();
        }
    }
}
