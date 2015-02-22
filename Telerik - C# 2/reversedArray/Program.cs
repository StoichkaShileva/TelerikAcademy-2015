using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 3, 2, 4, 5, 45, 23, 23 };
            string arrayInString = string.Join(", ", arr);

            int[] reversed = new int[arr.Length];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reversed[arr.Length - 1 - i] = arr[i];
            }

            string arrStr = string.Join(", ", reversed);
            Console.WriteLine(arrayInString);
            Console.WriteLine(arrStr);
        }
    }
}
