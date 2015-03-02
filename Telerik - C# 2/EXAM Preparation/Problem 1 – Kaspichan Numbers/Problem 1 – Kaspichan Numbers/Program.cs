using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Kaspichan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 255)
            {
                
            }
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUWXYZ";
            List<string> strs = new List<string>();
            string firstSpecialChar = "a";
            bool inSpecial = false;
            for (int i = 0, z = 1; i < 255; i++, z++)
            {
                if (i%25 == 0)
                {
                    inSpecial = true;
                }
                if (inSpecial)
                {
                    if (z < 25)
                    {
                        strs.Add(firstSpecialChar + alphabet[z].ToString().ToLower());
                    }
                    else
                    {
                        firstSpecialChar = alphabet[z].ToString().ToLower();
                    }
                }
                else
                {
                    strs.Add(alphabet[i].ToString());   
                }
            }
            string[] chars = new string[255];
            
            
        }
    }
}
