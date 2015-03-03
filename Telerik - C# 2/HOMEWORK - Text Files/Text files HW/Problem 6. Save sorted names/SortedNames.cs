/*Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
Example:

input.txt	output.txt
    Ivan 
    Peter 
    Maria 
    George	George 
    Ivan 
    Maria 
    Peter   
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Save_sorted_names
{
    class SortedNames
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of names that you will add: ");
            int numOfLines = int.Parse(Console.ReadLine());
            Console.WriteLine("For next {0} lines you'll have to enter names: ", numOfLines);
            List<string> firstFileVals = new List<string>();
            for (int i = 0; i < numOfLines; i++)
            {
                Console.Write("Line [{0}]: ", i + 1);
                firstFileVals.Add(Console.ReadLine());
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
            firstFileLines.Sort();
            StreamWriter writeSecondFile = new StreamWriter(secondFilePath);
            using (writeSecondFile)
            {
                for (int i = 0; i < firstFileLines.Count; i++)
                {
                    writeSecondFile.WriteLine(firstFileLines[i]);
                }
            }
            Console.WriteLine("Work is done! Sorted names are in fileB.txt file! Good BYE!");
        }
    }
}
