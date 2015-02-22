using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Four_Digit_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            bool isValid = false;
            while(!isValid)
            {
                if (num.Length != 4)
                {
                    Console.WriteLine("ERROR! You have to enter four-digit numeber! eg (1234)");
                    num = Console.ReadLine();
                }
                else
                {
                    isValid = true;
                    List<int> arr = new List<int>();
                    for (int i = 0; i < num.Length; i++)
                    {
                        arr.Add(int.Parse(num[i].ToString()));
                    }
                    Console.WriteLine(arr.Sum());
                    arr.Reverse();
                    foreach (var item in arr)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    arr.Reverse();
                    int[] secondArr = new int[4];
                    for (int i = 1; i < secondArr.Length; i++)
                    {
                        secondArr[i] = arr[i - 1];
                    }
                    secondArr[0] = arr[arr.Count - 1];
                    foreach (var item in secondArr)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    int secondDigit = arr[1];
                    int thirdDigit = arr[2];
                    arr[1] = thirdDigit;
                    arr[2] = secondDigit;
                    foreach (var item in arr)
                    {
                        Console.Write(item);   
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
