using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Angry_Female_GPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            long resultOfEven = 0;
            long resultOfOdd = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if(n[i] == '-')
                {
                    continue;
                }
                if(i % 2 == 0)
                {
                    resultOfEven += long.Parse(n[i].ToString());
                }
                else
                {
                    resultOfOdd += long.Parse(n[i].ToString());
                }
            }
            if (resultOfOdd == resultOfEven)
            {
                Console.WriteLine("straight {0}", resultOfEven);
            }
            else if(resultOfEven > resultOfOdd)
            {
                Console.WriteLine("right {0}", resultOfEven);
            }
            else if(resultOfOdd > resultOfEven)
            {
                Console.WriteLine("left {0}", resultOfOdd);
            }
            
        }
    }
}
