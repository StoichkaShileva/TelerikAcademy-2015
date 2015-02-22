using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> sheets = new Dictionary<string, int>();
            sheets.Add("A10", 1);
            sheets.Add("A9", 2);
            sheets.Add("A8", 4);
            sheets.Add("A7", 8);
            sheets.Add("A6", 16);
            sheets.Add("A5", 32);
            sheets.Add("A4", 64);
            sheets.Add("A3", 128);
            sheets.Add("A2", 256);
            sheets.Add("A1", 512);
            sheets.Add("A0", 1024);
            List<string> used = new List<string>();
            bool breakFirstLoop = false;
            while(true)
            {
                if(breakFirstLoop)
                {
                    break;
                }
                foreach (var item in sheets)
                {
                    if (n >= item.Value)
                    {
                        n /= item.Value;
                        used.Add(item.Key);
                    }
                    else if (n >= 0)
                    {
                        breakFirstLoop = true;
                    }
                }
            }
            for (int i = 0; i < used.Count; i++)
            {
                Console.WriteLine(used[i]);
            }
        }
    }
}
