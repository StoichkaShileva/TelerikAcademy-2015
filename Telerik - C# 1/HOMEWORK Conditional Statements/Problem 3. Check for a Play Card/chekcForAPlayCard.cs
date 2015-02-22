/*
 Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
 * Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Check_for_a_Play_Card
{
    class chekcForAPlayCard
    {
        static void Main(string[] args)
        {
            string c = Console.ReadLine();
            string code = c.ToUpper();
            string[] str = new string[13] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "K", "Q", "J"};
            bool isValid = false;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == code)
                {
                    isValid = true;
                }
            }
            if(isValid)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
