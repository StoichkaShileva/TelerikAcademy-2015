/*Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Problem_12.Parse_URL
{
    class ParseURL
    {
        static string ReturnProtocol(string url)
        {
            string protocol = string.Empty;
            for (int i = 0; i < url.Length; i++)
            {
                if (url[i] == '/' && url[i + 1] == '/')
                {
                    protocol += url[i];
                    protocol += url[i + 1];
                    break;
                }
                else
                {
                    protocol += url[i]; 
                }

            }

            return protocol;
        }

        static string ReturnServer(string url)
        {
            string server = string.Empty;
            bool isHaveToBreak = false;
            bool inInner = false;
            for (int i = 0; i < url.Length; i++)
            {
                if (isHaveToBreak == true)
                {
                    break;
                }
                if(inInner)
                {
                    for (int j = i; j < url.Length; j++)
                    {
                        if (url[j] != '/')
                        {
                            server += url[j];
                        }
                        else
                        {
                            isHaveToBreak = true;
                            break;
                        }
                    }
                }
                if (url[i] == '/' && url[i + 1] == '/')
                {
                    i += 1;
                    inInner = true;
                }
            }

            return server;
        }

        static string ReturnResource(string url)
        {
            string resource = String.Empty;
            bool isInRightStep = false;
            for (int i = 0; i < url.Length; i++)
            {
               
                if (url[i] == '/' && url[i - 1] != '/' && url[i - 1] != ':')
                {
                    isInRightStep = true;
                }
                if (isInRightStep)
                {
                    resource += url[i];
                }
            }
            return resource;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter URL address: ");
            string url = Console.ReadLine();

            string protocol = ReturnProtocol(url);
            string server = ReturnServer(url);
            string resource = ReturnResource(url);
            Console.WriteLine("Protocol is [{0}] | Server is [{1}] | Resource is [{2}]", protocol, server, resource);
        }
    }
}
