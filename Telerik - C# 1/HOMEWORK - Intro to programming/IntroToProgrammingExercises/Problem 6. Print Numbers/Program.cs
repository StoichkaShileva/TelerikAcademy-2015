using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Print_Numbers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {1, 101, 1001};
            foreach (var item in numbers)
            {
                Console.Write("{0} ", item);
            }
            
        }
    }
}
