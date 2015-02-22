using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            string forSubmit = "";
            for (int i = 1; i < n; i++)
			{
                forSubmit[i] += "-";
			}
            int nMultipliedByTwo = n * 2;
            //for (int i = 0; i < n * nMultipliedByTwo; i++)
            //{

            //}

            Console.WriteLine(forSubmit);
        }
    }
}
