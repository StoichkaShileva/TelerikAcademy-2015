using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Odd_or_Even_Integers
{
    class oddOrEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's odd or even");
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("{0} is even", num);
            }
            else
            {
                Console.WriteLine("{0} is odd", num);
            }
        }
    }
}
