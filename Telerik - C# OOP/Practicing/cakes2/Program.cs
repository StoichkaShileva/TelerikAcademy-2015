using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cakes2
{
    class Program
    {
        static void Main()
        {
            int money = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            int c3 = int.Parse(Console.ReadLine());

            int amountMax = 0;
            int amountTmp = 0;
            for (int i = c1; i >= 0; i--)
            {
                amountTmp = i*c1;
                if (amountTmp > amountMax && amountTmp <= money)
                {
                    amountMax = amountTmp;
                }
                for (int j = c2; j >= 0; j--)
                {
                    amountTmp = i * c1 + j * c2;
                    if (amountTmp > amountMax && amountTmp <= money)
                    {
                        amountMax = amountTmp;
                    }
                    for (int k = c3; k >= 0; k--)
                    {
                        amountTmp = i * c1 + j * c2 + k * c3;
                        if (amountTmp > amountMax && amountTmp <= money)
                        {
                            amountMax = amountTmp;
                        }
                    }
                }
            }
            Console.WriteLine(amountMax);
        }
    }
}
