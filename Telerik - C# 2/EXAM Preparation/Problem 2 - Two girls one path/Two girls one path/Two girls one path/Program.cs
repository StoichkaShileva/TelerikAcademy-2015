using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_2___Two_Girls__One_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] path = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
            BigInteger collectedFlowersA = 0;
            BigInteger collectedFlowersB = 0;
            BigInteger lastFlowerA = 0;
            BigInteger lastFlowerB = 0;
            bool isHaveToBreakA = false;
            bool isHaveToBreakB = false;

            BigInteger m = 0;
            BigInteger d = path.Length - 1;
            while (true)
            {
                m += lastFlowerA;
                d -= lastFlowerB;
                if (m == d && path[(int)m] != 0 && path[(int)d] != 0)
                {
                    if (path[(int)m] % 2 == 0)
                    {
                        BigInteger currentVal = path[(int)m] / 2;
                        collectedFlowersA += currentVal;
                        collectedFlowersB += currentVal;
                        path[(int)m] = 0;
                    }
                    else
                    {
                        BigInteger currentVal = path[(int)m] - 1;
                        BigInteger separated = currentVal / 2;
                        collectedFlowersA += separated;
                        collectedFlowersB += separated;
                        path[(int)m] = 1;
                    }
                }
                if (m > path.Length)
                {
                    m = m % path.Length;
                }
                if (d < 0)
                {
                    d = path.Length - (d*-1);
                }
                lastFlowerA = path[(int)m];
                if (lastFlowerA != 0)
                {
                    collectedFlowersA += path[(int)m];
                    path[(int) m] = 0;
                }
                else
                {
                    isHaveToBreakA = true;
                }
                lastFlowerB = path[(int)d];
                if (lastFlowerB != 0)
                {
                    collectedFlowersB += path[(int)d];
                    path[(int)d] = 0;
                }
                else
                {
                    isHaveToBreakB = true;
                }

                if (isHaveToBreakB == true && isHaveToBreakA == true)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine("{0} {1}", collectedFlowersA, collectedFlowersB);
                    break;
                }
                if (isHaveToBreakA == true && isHaveToBreakB == false)
                {
                    Console.WriteLine("Dolly");
                    Console.WriteLine("{0} {1}", collectedFlowersA, collectedFlowersB);
                    break;
                }
                else if (isHaveToBreakB == true && isHaveToBreakA == false)
                {
                    Console.WriteLine("Molly");
                    Console.WriteLine("{0} {1}", collectedFlowersA, collectedFlowersB);
                    break;
                }
            }
        }
    }
}
