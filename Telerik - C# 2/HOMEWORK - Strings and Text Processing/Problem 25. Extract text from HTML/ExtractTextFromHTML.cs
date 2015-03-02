/*Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_25.Extract_text_from_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter HTML text: ");
            string htmlTxt = Console.ReadLine();
            MatchCollection result = Regex.Matches(htmlTxt, "(?<=^|>)[^><]+?(?=<|$)");
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}
