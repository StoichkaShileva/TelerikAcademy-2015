using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Divide_by_7_and_5
{
    class devideBy7And5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number to check if it can be saparable by 7 and 5 in the same time");
            int num = int.Parse(Console.ReadLine());
            bool isSaparable = false;
            if(num % 7 == 0 && num % 5 == 0)
            {
                isSaparable = true;
            }

            Console.WriteLine(isSaparable);
        }
    }
}
