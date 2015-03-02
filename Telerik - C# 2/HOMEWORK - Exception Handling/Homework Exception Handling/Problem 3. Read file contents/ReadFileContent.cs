/*Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_3.Read_file_contents
{
    class ReadFileContent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file path: (example: C:\\WINDOWS\\win.ini):");
            string path = Console.ReadLine();
            try
            {
                string textInFile = File.ReadAllText(path);
                Console.WriteLine(textInFile);
            }
            catch (Exception ex) //Catching all possible exceptions like argumentException, securityException and so on.
            {
                Console.WriteLine(ex.Message); //Giving user friendly message
            }
        }
    }
}
