/*Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_18.Extract_e_mails
{
    class Program
    {
        static List<string> ReturnUsingRegex(string text)
        {
            List<string> emails = new List<string>();
            string pattern = @"[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-z]{2,8}";
            MatchCollection e = Regex.Matches(text, pattern);
            foreach (Match item in e)
            {
                emails.Add(item.Value.ToString());
            }
            return emails;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text that contains e-mails: ");
            string text = Console.ReadLine();
            List<string> emails = new List<string>();

            //LOGIC Without REGEX ->
            for (int i = 0; i < text.Length; i++)
            {
                string finalMail = string.Empty;

                string currentIdentifier = string.Empty;
                string currentHost = string.Empty;
                string currentDomain = string.Empty;
                if (text[i] == '@' && i-1 > 0 && text[i-1] != ' ')
                {
                    int curr = i;
                    curr -= 1;
                    while (!char.IsWhiteSpace(text[curr]) && curr > 0)
                    {
                        currentIdentifier += text[curr];
                        curr--;
                    }

                    curr = i;
                    while (text[curr+1] != '.')
                    {
                        curr++;
                        currentHost += text[curr];
                    }
                    curr++;
                    while (curr+1 < text.Length && !char.IsWhiteSpace(text[curr]))
                    {
                        curr++;
                        currentDomain += text[curr];
                    }
                }
                if (currentIdentifier != string.Empty && currentHost != string.Empty && currentDomain != string.Empty)
                {
                    char[] reversedIdent = currentIdentifier.ToCharArray();
                    Array.Reverse(reversedIdent);
                    currentIdentifier = new string(reversedIdent);
                    finalMail += currentIdentifier;
                    finalMail += '@';

                    finalMail += currentHost;
                    finalMail += '.';
                    finalMail += currentDomain;
                }

                if (finalMail != string.Empty)
                {
                    emails.Add(finalMail);
                }
            }

            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }

            //LOGIC WITH REGEX ->
            List<string> emailsRegex = ReturnUsingRegex(text);
            foreach (var i in emailsRegex)
            {
                Console.WriteLine(i);
            }
        }
    }
}
