using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Exchange_Variable_Values
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            //Before exchange
            Console.WriteLine(a + " " + b);
            
            //Variable C that helps us to exchange A and B values
            int c;
            c = b;
            b = a;
            a = c;

            //After exchange
            Console.WriteLine(a + " " + b);
        }
    }
}
