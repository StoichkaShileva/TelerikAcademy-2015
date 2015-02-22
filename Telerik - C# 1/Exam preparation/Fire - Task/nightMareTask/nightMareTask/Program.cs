using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nightMareTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            decimal num = 0;
            decimal howManyTimes = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if(i % 2 != 0)
                {
                    howManyTimes++;
                    num += decimal.Parse(n[i].ToString());
                }
            }
            Console.WriteLine("{0} {1}", howManyTimes, num);
        }
    }
}
