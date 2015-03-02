/*Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Problem_4.Download_file
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            try
            {
                web.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png",
                    Directory.GetCurrentDirectory());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
            }
            
        }
    }
}
