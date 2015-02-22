/*
 *Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Say_Hello
{
    class SayHello
    {
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            PrintName(name);
        }
    }
}
