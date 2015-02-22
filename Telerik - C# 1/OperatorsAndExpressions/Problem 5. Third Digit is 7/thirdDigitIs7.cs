using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Third_Digit_is_7
{
    class thirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if the third digit is 7");
            string num = Console.ReadLine();
            int index = num.Length - 3;
            if(num[index] == '7')
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
