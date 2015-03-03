/*Write a program that reads a text file and prints on the console its odd lines.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_1.Odd_lines
{
    class OddLines
    {
        private static void Main(string[] args)
        {
            StreamWriter writter = new StreamWriter(@"..\..\file.txt");
            using (writter)
            {
                for (int i = 0; i < 40; i++)
                {
                    writter.WriteLine("{0} _._ {1}", i, new string('!', i));
                }
            }

            StreamReader reader = new StreamReader(@"..\..\file.txt");
            using (reader)
            {
                string curr = reader.ReadLine();
                for (int i = 0; curr != null; i++)
                {
                    curr = reader.ReadLine();
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(curr);
                    }
                }
            }

        }
    }
}
