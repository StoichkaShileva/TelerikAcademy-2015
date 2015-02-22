/* 
 Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9_Play_with_Int__Double
{
    class playWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type: ");
            Console.WriteLine("1 -> int");
            Console.WriteLine("2 -> double");
            Console.WriteLine("3 -> string");
            string type = Console.ReadLine();
            if(type == "int")
            {
                //Console.WriteLine("here");
                int intVar = int.Parse(Console.ReadLine());
                Console.WriteLine(intVar += 1);
            }
            else if (type == "double")
            {
                double doubleVar = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleVar += 1);
            }
            else if (type == "string")
            {
                string strVar = Console.ReadLine();
                Console.WriteLine(strVar += '*');
            }
        }
    }
}
