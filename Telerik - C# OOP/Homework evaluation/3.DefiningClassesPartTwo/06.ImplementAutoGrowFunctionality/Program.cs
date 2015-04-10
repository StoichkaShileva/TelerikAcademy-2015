using System;
//Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

class Program
{
    static void Main()
    {
        GenericList<int> list = new GenericList<int>(5);
        list.Add(6);
        list.Add(5);
        list.Add(4);
        list.Add(3);
        list.Add(2);
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(6);
        list.Add(7);
        list.InsertAt(-1024, 4);
        Console.WriteLine(list);
        Console.WriteLine("The count of the array is:{0}", list.Count);
        Console.WriteLine("The capacity of the array is:{0}", list.Capacity);
    }
}
