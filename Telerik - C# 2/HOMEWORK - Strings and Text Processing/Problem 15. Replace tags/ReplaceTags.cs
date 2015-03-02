/*Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Replace_tags
{
    class ReplaceTags
    {
        static void Main()
        {
            Console.WriteLine("Enter html document to escape <a href=\"..\"> tags: ");
            StringBuilder text = new StringBuilder();
            string txt = Console.ReadLine();
            for (int i = 0; i < txt.Length; i++)
            {
                text.Append(txt[i]);
            }
            text = text.Replace("<a href=", "[URL=");
            text = text.Replace("</a>", "[/URL]");
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '[' && i + 1 < text.Length && text[i+1] != '/')
                {
                    int index = txt.IndexOf(">", i);
                    if (index != -1)
                    {
                        text[index-4] = ']';
                    }
                }
            }
            Console.WriteLine(text.ToString());
        }
    }
}
