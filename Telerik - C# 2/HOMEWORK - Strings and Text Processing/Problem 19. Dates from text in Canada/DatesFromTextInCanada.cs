/*Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_19.Dates_from_text_in_Canada
{
    class Dates
    {
        static List<string> ReturnDates(string text)
        {
            List<string> dates = new List<string>();
            string pattern = @"[a-z]{1,2}.[0-9]{1,2}.[0-9]{1,4}";
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                dates.Add(match.Value.ToString());
            }
            return dates;    
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text that contains dates in format(DD.MM.YYYY):");
            string text = Console.ReadLine();

            List<string> dates = ReturnDates(text);
            for (int i = 0; i < dates.Count; i++)
            {
                dates[i] = (DateTime.ParseExact(dates[i], "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None)).ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern);
            }

            foreach (var date in dates)
            {
                Console.WriteLine(date);
            }
            
        }
    }
}
