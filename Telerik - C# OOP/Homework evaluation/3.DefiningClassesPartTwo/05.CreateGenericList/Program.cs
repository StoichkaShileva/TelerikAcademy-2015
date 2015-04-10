using System;
//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index,
//inserting element at given position, clearing the list, finding element by its value and ToString(). 
//Check all input parameters to avoid accessing elements at invalid positions.

class Program
{
    static void Main()
    {
        try
        {
            GenericList<int> list = new GenericList<int>(5);
            list.Add(6);//Add an item
            list.Add(3);
            list.Add(8);
            list.Add(7);
            Console.WriteLine(list);
            Console.WriteLine();

            list[3] = 9;//Access the item by index
            Console.WriteLine(list);
            Console.WriteLine();

            list.RemoveAt(1);//Remove element at given position
            Console.WriteLine(list);
            Console.WriteLine();

            list.InsertAt(1024, 0);//Insert element at given position
            Console.WriteLine(list);
            Console.WriteLine();

            list.Clear();//Clear the whole array
            Console.WriteLine(list);//Now it is empty
            Console.WriteLine();

            list.Add(6);
            list.Add(3);
            list.Add(8);
            list.Add(7);
            list.Add(5);
            Console.WriteLine(list);
            Console.WriteLine();
            Console.WriteLine(list.Find(8));//Return the index of the searched item, or -1 if there isn't such element
            
            Console.WriteLine("The count of the array is:{0}",list.Count);
            Console.WriteLine("The capacity of the array is:{0}", list.Capacity);

            //These will throw exception:

            //list.Add(2);
            //list[20] = 0;
            //list.RemoveAt(-4);
            //list.InsertAt(6,7);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}