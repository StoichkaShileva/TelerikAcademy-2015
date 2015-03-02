/*You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Parse_tags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text that contains text surrounded by <upcase> and </upcase>");
            string text = Console.ReadLine();
            string modified = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                int indexOpen = text.IndexOf("<upcase>", i);
                int indexClose = text.IndexOf("</upcase>", i);
                if (i == indexOpen)
                {
                    if (indexOpen != -1 && indexClose != -1)
                    {
                        for (int j = indexOpen + 8; j < indexClose; j++)
                        {
                            modified += text[j].ToString().ToUpper();
                        }
                        i += indexClose - indexOpen + 9;
                    }
                }
                if (i < text.Length)
                {
                    modified += text[i];
                }
                
            }
            Console.WriteLine(modified);
        }
    }
}
