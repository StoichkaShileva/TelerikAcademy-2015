using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Problem_2.Concatenate_text_files
{
    class ConcatanateTextFiles
    {
        static void Main(string[] args)
        {
            string firstFilePath = @"..\..\fileA.txt";
            string secondFilePath = @"..\..\fileB.txt";
            StreamWriter firstFile = new StreamWriter(firstFilePath);
            try
            {
                using (firstFile)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        firstFile.WriteLine("YEA! {0}", i + 12 / 28);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("ERROR AT SETTING FILE #1");
            }
            try
            {
                StreamWriter secondFile = new StreamWriter(secondFilePath);
                using (secondFile)
                {
                    for (int i = 0, z = 124; i < 10; i++, z += 83)
                    {
                        secondFile.WriteLine("JA NO!XXXX {0}", i + -187 * z);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            ConcatanateFiles(firstFilePath, secondFilePath);
        }

        private static void ConcatanateFiles(string firstFilePath, string secondFilePath)
        {
            string thirdFilePath = @"..\..\concatanatedFiles.txt";
            string textFromFirstFile = string.Empty;
            string textFromSecondFile = string.Empty;

            StreamReader readFirstFile = new StreamReader(firstFilePath);
            using (readFirstFile)
            {
                string readFirst = readFirstFile.ReadLine();
                while (readFirst != null)
                {
                    textFromFirstFile += readFirst;
                    readFirst = readFirstFile.ReadLine();
                } 
            }
            StreamReader readSecondFile = new StreamReader(secondFilePath);
            using (readSecondFile)
            {
                string readSecond = readSecondFile.ReadLine();
                while (readSecond != null)
                {
                    textFromSecondFile += readSecond;
                    readSecond = readSecondFile.ReadLine();
                }  
            }

            try
            {
                StreamWriter writeToThirdFile = new StreamWriter(thirdFilePath);
                using (writeToThirdFile)
                {
                    writeToThirdFile.WriteLine(textFromFirstFile);
                    writeToThirdFile.WriteLine(textFromSecondFile);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
