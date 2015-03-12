/*
Problem 5. Generic class

Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
Check all input parameters to avoid accessing elements at invalid positions.
Problem 6. Auto-grow

Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
Problem 7. Min and Max

Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
You may need to add a generic constraints for the type T.

*/
namespace Generic_class
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class ProgramStart
    {
        static void Main(string[] args)
        {
            GenericClass<int> items = new GenericClass<int>(5);
            for (int i = 0; i < 10; i++)
            {
                items.AddElement(++i);
                --i;
            }
            items.AddElement(200000);
            Console.WriteLine(items.Max());
            Console.WriteLine(items.ToString());
        }
    }
}
