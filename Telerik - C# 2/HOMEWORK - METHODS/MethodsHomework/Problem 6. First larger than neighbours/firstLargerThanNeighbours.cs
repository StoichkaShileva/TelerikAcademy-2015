/*
 *Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.First_larger_than_neighbours
{
    class firstLargerThanNeighbours
    {
        static int checkIfTheNumIsBigger(int[] arr)
        {
            int numThatIsBigger = 0;
            for (int i = 1; i < arr.Length - 2; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    numThatIsBigger = arr[i];
                    break;
                }
            }

            return numThatIsBigger;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array digits seperated with single space");
            int[] arrOfDigits =
                Console.ReadLine()
                    .Split(new string[] { " ", ", ", "," }, StringSplitOptions.None)
                    .Select(x => int.Parse(x))
                    .ToArray();
            int num = checkIfTheNumIsBigger(arrOfDigits);
            Console.WriteLine("The first bigger num than its neighbours is {0}", num);
        }
    }
}
