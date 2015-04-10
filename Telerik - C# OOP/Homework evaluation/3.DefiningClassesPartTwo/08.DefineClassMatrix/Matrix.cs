using System;
using System.Collections.Generic;
using System.Text;

class Matrix<T>
{
    //Fields
    private int size;
    private T[,] array = new T[5,5];
    
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

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < this.Size; i++)
        {
            for (int j = 0; j < this.Size; j++)
            {
                sb.Append(this.Array[i,j].ToString());
                sb.Append(" ");
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
