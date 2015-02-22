using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Task
{
    class Fire
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int halfWidth = width / 2;
            int widthByFour = width / 4;
            char fire = '#';
            char topTorch = '-';
            char leftTorch = '\\';
            char rightTorch = '/';
            char empty = '.';

            //Fire top
            for (int i = 0; i < halfWidth; i++)
            {
                Console.Write(new string(empty, halfWidth - i - 1));
                Console.Write(new string(fire, 1));
                Console.Write(new string(empty, i * 2));
                Console.Write(new string(fire, 1));
                Console.WriteLine(new string(empty, halfWidth - i - 1));
            }

            //Fire bottom
            for (int i = 0; i < widthByFour; i++)
            {
                Console.Write(new string(empty, i));
                Console.Write(new string(fire, 1));
                Console.Write(new string(empty, (width - (i * 2 + 2))));
                Console.Write(new string(fire, 1));
                Console.WriteLine(new string(empty, i));

            }

            //Print torch top
            Console.WriteLine(new string(topTorch, width));

            //Torch bottom
            for (int i = 0; i < halfWidth; i++)
            {
                Console.Write(new string(empty, i));
                Console.Write(new string(leftTorch, halfWidth - i));
                Console.Write(new string(rightTorch, halfWidth - i));
                Console.WriteLine(new string(empty, i));
            }
        }
    }
}
