using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Variable_in_Hexadecimal_Format
{
    class HexDecimalFormat
    {
        static void Main(string[] args)
        {
            int value = 254;
            string myHex = value.ToString("X");
            Console.WriteLine(myHex);
        }
    }
}
