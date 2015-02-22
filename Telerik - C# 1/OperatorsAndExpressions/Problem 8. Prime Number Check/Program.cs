using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Prime_Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = false;
            for (int i = 1; i < Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    isPrime = true;
                }
            }
            if(isPrime)
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
