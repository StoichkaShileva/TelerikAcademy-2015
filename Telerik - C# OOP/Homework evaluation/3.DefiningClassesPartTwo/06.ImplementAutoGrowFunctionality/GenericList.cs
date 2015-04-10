using System;
using System.Collections.Generic;
using System.Text;

class GenericList<T>
where T : IComparable, new()
{
    //Fields
    private T[] array;
    private int index;//variable that hepls us to add items to the correct position

    //Properties
    public T[] Array
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
    public int Capacity
    {
        get
        {
            return this.Array.Length;
        }
    }
    public int Count
    {
        get
        {
            return this.index;
        }
    }

    //Accessing element by index
    public T this[int index]
    {
        get
        {
            if (index >= 0 && index < this.Array.Length)
            {
                return this.Array[index];
            }
            else throw new IndexOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < this.Array.Length)
            {
                this.Array[index] = value;
            }
            else throw new IndexOutOfRangeException();
        }
    }

    //Constructor
    public GenericList(int capacity)
    {
        this.Array = new T[capacity];
        this.index = 0;
    }

    //Methods
    private void AutoGrow()//Double the capacity of the array
    {
        T[] copied = (T[])this.Array.Clone();
        this.Array = new T[this.Array.Length * 2];
        for (int i = 0; i < copied.Length; i++)
        {
            this.Array[i] = copied[i];
        }
    }
    public void Add(T element)
    {
        if (index == this.Array.Length)
        {
            this.AutoGrow();
        }
        this.Array[index] = element;
        index++;
    }
    public void RemoveAt(int insertedIndex)
    {
        if (insertedIndex >= 0 && insertedIndex < this.Array.Length)
        {
            for (int i = insertedIndex; i < this.Array.Length - 1; i++)
            {
                this.Array[i] = this.Array[i + 1];
            }
            this.Array[this.Array.Length - 1] = new T();
        }
        else throw new IndexOutOfRangeException();
        index--;
    }
    public void InsertAt(T element, int insertedIndex)
    {
        if (index == this.Array.Length)
        {
            this.AutoGrow();
        }
        if (insertedIndex >= 0 && insertedIndex < this.Array.Length)
        {
            for (int i = this.Array.Length - 1; i > insertedIndex; i--)
            {
                this.Array[i] = this.Array[i - 1];
            }
            this.Array[insertedIndex] = element;
        }
        else throw new IndexOutOfRangeException();
        index++;
    }
    public void Clear()
    {
        for (int i = 0; i < this.Array.Length; i++)
        {
            this.Array[i] = new T();
        }
        index = 0;
    }
    public int Find(T element)//Returns the index of the element or -1 if it is not found
    {
        for (int i = 0; i < this.Array.Length; i++)
        {
            if (element.CompareTo(this.Array[i]) == 0)
            {
                return i;
            }
        }
        return -1;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < index; i++)
        {
            sb.AppendLine(this.Array[i].ToString());
        }
        return sb.ToString().TrimEnd();
    }
}
