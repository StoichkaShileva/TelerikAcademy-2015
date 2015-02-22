using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace nightMareTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            BigInteger num = 0;
            BigInteger howManyTimes = 0;
            BigInteger iterator = 0;
            foreach (BigInteger value in n)
            {
                if (iterator % 2 != 0)
                {
                    howManyTimes++;
                    num += value - '0';
                }
                iterator++;
            }
            Console.WriteLine("{0} {1}", howManyTimes, num);
        }
    }
}
