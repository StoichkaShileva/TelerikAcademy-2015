using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Print_a_Sequence
{
    class SequenceOfNumbers
    {
        static void Main(string[] args)
        {
            int count = 5;
            for (int i = 2; i < 11; i+=2)
            {
                Console.Write("{0} ",i);
                Console.Write("{0} ", i-count);
                count += 4;
            }
        }
    }
}
