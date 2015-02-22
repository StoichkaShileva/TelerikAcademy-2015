using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Ones_and_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char hash = '#';
            char dot = '.';
            string binary1 = Convert.ToString(num, 2).PadLeft(16, '0');
            string binary = binary1.Substring(binary1.Length - 16, 16);
            for (int row = 1; row <= 5; row++)
            {
                for (int j = 0; j < binary.Length; j++)
                {
                    if ((binary[j] == '0' && row == 1) || (binary[j] == '0' && row == 5))
                    {
                        Console.Write(new string(hash, 3));
                    }
                    else if (binary[j] == '0' && (row == 2 || row == 3 || row == 4))
                    {
                        Console.Write(hash);
                        Console.Write(dot);
                        Console.Write(hash);
                    }
                    else if (binary[j] == '1' && (row == 1 || row == 3 || row == 4))
                    {
                        Console.Write(dot);
                        Console.Write(hash);
                        Console.Write(dot);
                    }
                    else if (binary[j] == '1' && row == 2)
                    {
                        Console.Write(new string(hash, 2));
                        Console.Write(dot);
                    }
                    else if (binary[j] == '1' && row == 5)
                    {
                        Console.Write(new string(hash, 3));
                    }
                    if(j != binary.Length - 1)
                    {
                        Console.Write(dot);
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
