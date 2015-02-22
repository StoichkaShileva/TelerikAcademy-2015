using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Eggcelent
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6; //int.Parse(Console.ReadLine());
            int height = n * 2;
            int width = n * 3 - 1;
            char empty = '.';
            char star = '*';
            char monkeyA = '@';
            bool isNeedableToPutMonkey = true;
            bool isNeedableToPutEmpty = true;
            //TOP

            int second = n;
            int lineRow = 0;

            for (int i = 0; i < n  - 1; i++)
            {
                Console.Write(new string(empty, width / 2 - i * 2));
                Console.Write(new string(star, 1));
                if(i == 0)
                {
                    Console.Write(new string(star, 1));
                }
                else
                {
                    lineRow += second + 1;
                    //second++;
                    --second;
                    Console.Write(new string(empty, lineRow));   
                }
                Console.Write(new string(star, 1));
                Console.WriteLine(new string(empty, width / 2 - i * 2));
            }

            //middle
            for (int i = 0; i < 2; i++)
            {
                Console.Write(new string(empty, 1));
                Console.Write(new string(star, 1));
                if(i == 0)
                {
                    for (int j = 0; j < ((width - 4) + 2); j++)
			        {
                        if(j == width / - 6)
                        {
                            isNeedableToPutMonkey = false;
                            isNeedableToPutEmpty = false;
                        }
                        if(isNeedableToPutMonkey)
                        {
                            Console.Write(new string(monkeyA, 1));
                            isNeedableToPutMonkey = false;
                            isNeedableToPutEmpty = true;
                        }
                        else if(isNeedableToPutEmpty)
                        {
                            Console.Write(new string(empty, 1));
                            isNeedableToPutEmpty = false;
                            isNeedableToPutMonkey = true;
                        }
                        
			        }
                }
                else
                {
                    isNeedableToPutEmpty = true;
                    isNeedableToPutMonkey = true;
                    for (int j = 0; j < ((width - 4) + 2); j++)
                    {
                        if (j == width / -6)
                        {
                            isNeedableToPutMonkey = false;
                            isNeedableToPutEmpty = false;
                        }
                        if(isNeedableToPutEmpty)
                        {
                            Console.Write(new string(empty, 1));
                            isNeedableToPutEmpty = false;
                            isNeedableToPutMonkey = true;
                        }
                        else if(isNeedableToPutMonkey)
                        {
                            Console.Write(new string(monkeyA, 1));
                            isNeedableToPutMonkey = false;
                            isNeedableToPutEmpty = true;
                        }
                    }
                }
                Console.Write(new string(star, 1));
                Console.WriteLine(new string(empty, 1));
            }
        }
    }
}
