/*Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_3.Line_numbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\example.txt";
            //Creating example file
            StreamWriter writeExample = new StreamWriter(filePath);
            using (writeExample)
            {
                for (int i = 0; i < 100; i++)
                {
                    writeExample.WriteLine("HEY!");
                }
            }
            StreamReader readFile = new StreamReader(filePath);
            StringBuilder file = new StringBuilder();
            int fileLines = 0;
            using (readFile)
            {
                var currentRead = readFile.ReadLine();
                while (currentRead != null)
                {
                    fileLines++;
                    StreamWriter writeToNewFile = new StreamWriter(@"..\..\newfile.txt", true);
                    using (writeToNewFile)
                    {
                        writeToNewFile.WriteLine("[{0}] {1}", fileLines, currentRead);
                    }
                    file.Append(currentRead);
                    currentRead = readFile.ReadLine();
                }               
            }
        }
    }
}
