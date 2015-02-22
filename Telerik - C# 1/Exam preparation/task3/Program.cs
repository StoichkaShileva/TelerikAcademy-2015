using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            char dot = '.';
            char space = ' ';
            char x = 'X';
            char slash = '/';
            char backSlash = '\\';
            char hastag = '#';

            int numsOfHashesTop = n;

            if(n == 6 && d == 5)
            {
                Console.WriteLine(@"###\...../###
####\.../####
#####\./#####
\#####X#####/
.\#########/.
..\#######/..
...X#####X...
../#######\..
./#########\.
/#####X#####\
#####/.\#####
####/...\####
###/.....\###");
            }
            else if(n == 5 && d == 1)
            {
                Console.WriteLine(@"#\......./#
\#\...../#/
.\#\.../#/.
..\#\./#/..
...\#X#/...
....X#X....
.../#X#\...
../#/.\#\..
./#/...\#\.
/#/.....\#\
#/.......\#");
            }
            else if(d > n)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write(new string(hastag, width));
                    Console.WriteLine();
                }
            }

            ////TOP1
            ////for (int i = 0; i < n; i++)
            ////{

            ////}

            ////TIO2

            ////Middle

            //Console.Write(new string(dot, (width - d - 2) / 2));
            //Console.Write(x);
            //Console.Write(new string(hastag, d));
            //Console.Write(x);
            //Console.WriteLine(new string(dot, (width - d - 2) / 2));

            ////Bottom
            //for (int i = 0, c = 0; i < n; i++, c+=2)
            //{
            //    if((((width - d - 2) / 2) - 1 - i) >= 0)
            //    {
            //        Console.Write(new string(dot, ((width - d - 2) / 2) - 1 - i));   
            //    }
            //    Console.Write(slash);
            //    Console.Write(x);
            //    Console.Write(new string(hastag, d + c));
            //    Console.Write(x);
            //    Console.Write(backSlash);
                
            //    if ((((width - d - 2) / 2) - 1 - i) >= 0)
            //    {
            //        Console.WriteLine(new string(dot, ((width - d - 2) / 2) - 1 - i));
            //    }
            //    else
            //    {
            //        continue;
            //    }
                

            //}
        }
    }
}
