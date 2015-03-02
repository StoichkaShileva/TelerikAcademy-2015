using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRES4_Numbers
{
    class tres
    {
        static string ReturnAsStr(ulong num)
        {
            string val = string.Empty;
            switch (num)
            {
                case 0:
                    val = "LON+";
                    break;
                case 1:
                    val = "VK-";
                    break;
                case 2:
                    val = "*ACAD";
                    break;
                case 3:
                    val = "^MIM";
                    break;
                case 4:
                    val = "ERIK|";
                    break;
                case 5:
                    val = "SEY&";
                    break;
                case 6:
                    val = "EMY>>";
                    break;
                case 7:
                    val = "/TEL";
                    break;
                case 8:
                    val = "<<DON";
                    break;

            }
            return val;
        }
        static string DecimalToBin(ulong num)
        {
            string result = string.Empty;
            List<string> heres = new List<string>();
            bool isHaveToBreak = false;
            while (!isHaveToBreak)
            {
                if (num / 9 > 0 || num == 1 && num > 9)
                {
                    heres.Add(ReturnAsStr(num % 9));
                    num /= 9;
                }
                else if (num / 9 <= 0 || num < 9)
                {
                    isHaveToBreak = true;
                    heres.Add(ReturnAsStr(num));
                }
            }
            for (int i = heres.Count - 1; i >= 0; i--)
            {
                result += heres[i];
            }
            //Array.Reverse(arr);
            //string asd = new string(arr);
            return result;
        }
        static void Main(string[] args)
        {
            ulong num = ulong.Parse(Console.ReadLine());
            string final = DecimalToBin(num);
            Console.WriteLine(final);
        }
    }
}
