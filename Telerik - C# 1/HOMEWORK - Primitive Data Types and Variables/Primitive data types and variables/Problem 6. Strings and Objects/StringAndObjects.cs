using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Strings_and_Objects
{
    class StringAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "hello";
            string world = "world";
            object concatenated = hello + " " + world;
            string finalVariable = (string)concatenated;
            Console.WriteLine(finalVariable);
        }
    }
}
