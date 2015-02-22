/* 
 Write a program that reads two integer arrays from the console and compares them element by element.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Compare_arrays
{
    class CompareArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of the first int array: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("On the next {0} lines you'll have to enter int digits: ", length);
            int[] firstArrr = new int[length];
            for (int i = 0; i < length; i++)
            {
                firstArrr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter length of the second int array: ");
            int lengthSecondArr = int.Parse(Console.ReadLine());
            Console.WriteLine("On the next {0} lines you'll have to enter int digits: ", lengthSecondArr);
            int[] secondArr = new int[lengthSecondArr];
            for (int i = 0; i < lengthSecondArr; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }

            bool areTheyDifferent = false;
            if(firstArrr.Length != secondArr.Length)
            {
                areTheyDifferent = true;
            }
            else
            {
                for (int i = 0; i < firstArrr.Length; i++)
                {
                    if(firstArrr[i] != secondArr[i])
                    {
                        areTheyDifferent = true;
                    }
                }
            }
            Console.WriteLine("Is the first array different from the second? {0}!", areTheyDifferent);

        }
    }
}
