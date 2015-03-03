/*Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Compare_text_files
{
    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of lines for both files: ");
            int numOfLines = int.Parse(Console.ReadLine());
            Console.WriteLine("For next {0} lines you'll have to enter values for the first file: ", numOfLines);
            List<string> firstFileVals = new List<string>();
            for (int i = 0; i < numOfLines; i++)
            {
                Console.Write("Line [{0}]: ", i+1);
                firstFileVals.Add(Console.ReadLine());
            }
            Console.WriteLine("For next {0} lines you'll have to enter values for the second file: ", numOfLines);
            List<string> secondFileVals = new List<string>();
            for (int i = 0; i < numOfLines; i++)
            {
                Console.Write("Line [{0}]: ", i + 1);
                secondFileVals.Add(Console.ReadLine());
            }
            const string firstFilePath = @"..\..\fileA.txt";
            const string secondFilePath = @"..\..\fileB.txt";
            StreamWriter writeFileOne = new StreamWriter(firstFilePath);
            using (writeFileOne)
            {
                for (int i = 0; i < firstFileVals.Count; i++)
                {
                    writeFileOne.WriteLine(firstFileVals[i]);
                }
            }
            StreamWriter writeSecondFile = new StreamWriter(secondFilePath);
            using (writeSecondFile)
            {
                for (int i = 0; i < firstFileVals.Count; i++)
                {
                    writeSecondFile.WriteLine(secondFileVals[i]);
                }
            }
            List<string> firstFileLines = new List<string>();
            StreamReader readFirstFile = new StreamReader(firstFilePath);
            using (readFirstFile)
            {
                string readLine = readFirstFile.ReadLine();
                while (readLine != null)
                {
                    firstFileLines.Add(readLine);
                    readLine = readFirstFile.ReadLine();
                }
            }
            List<string> secondFileLines = new List<string>();
            StreamReader readSecondFile = new StreamReader(secondFilePath);
            using (readFirstFile)
            {
                string readLine = readSecondFile.ReadLine();
                while (readLine != null)
                {
                    secondFileLines.Add(readLine);
                    readLine = readSecondFile.ReadLine();
                }
            }
            int equalLines = 0;
            int differentLines = 0;
            for (int i = 0; i < firstFileLines.Count; i++)
            {
                if (firstFileLines[i] == secondFileLines[i])
                    equalLines++;
                else 
                    differentLines++;
            }
            Console.WriteLine("Equal lines are: {0}", equalLines);
            Console.WriteLine("Different lines are: {0}", differentLines);
        }
    }
}
