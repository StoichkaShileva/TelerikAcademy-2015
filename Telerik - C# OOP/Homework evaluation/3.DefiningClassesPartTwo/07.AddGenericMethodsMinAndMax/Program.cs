using System;
//Create generic methods Min<T>() and Max<T>() for finding the minimal
//and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.

class Program
{
    static void Main()
    {
        GenericList<int> list = new GenericList<int>(5);
        list.Add(4);
        list.Add(7);
        list.Add(2);
        list.Add(3);
        list.Add(6);
        list.Add(5);
        //Console.WriteLine(list);
        Console.WriteLine(list.Min());
        Console.WriteLine(list.Max());
    }
}
