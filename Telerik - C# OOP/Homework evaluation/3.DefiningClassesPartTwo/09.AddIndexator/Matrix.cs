using System;
using System.Collections.Generic;
using System.Text;

class Matrix<T>
{
    //Fields
    private int size;
    private T[,] array = new T[5, 5];

    //Properties
    private T[,] Array
    {
        set
        {
            this.array = value;
        }
        get
        {
            return this.array;
        }
    }
    private int Size
    {
        set
        {
            if (value >= 0)
            {
                this.size = value;
            }
            else throw new IndexOutOfRangeException();
        }
        get
        {
            return this.size;
        }
    }

    //Constructor
    public Matrix(int insertedSize)
    {
        this.Size = insertedSize;
        this.Array = new T[this.Size, this.Size];
    }

    //Indexator
    public T this[int row, int col]
    {
        get
        {
            if (row >= 0 && row < this.Size && col >= 0 && col < this.Size)
            {
                return this.Array[row, col];
            }
            else throw new IndexOutOfRangeException();
        }
        set
        {
            if (row >= 0 && row < this.Size)
            {
                if (col >= 0 && col < this.Size)
                {
                    this.Array[row, col] = value;
                }
            }
            else throw new IndexOutOfRangeException();
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < this.Size; i++)
        {
            for (int j = 0; j < this.Size; j++)
            {
                sb.Append(this.Array[i, j].ToString());
                sb.Append(" ");
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
