using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Peace_of_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal positiveA = decimal.Parse(Console.ReadLine());
            decimal positiveB = decimal.Parse(Console.ReadLine());
            decimal positiveC = decimal.Parse(Console.ReadLine());
            decimal positiveD = decimal.Parse(Console.ReadLine());

            decimal firstCake = positiveA / positiveB;
            decimal secondCake = positiveC / positiveD;

            decimal allCakesSum = firstCake + secondCake;
            decimal denominator = positiveB * positiveD;
            decimal nominator = allCakesSum * denominator;
            decimal roundedNominator = Math.Round(nominator, 0);
            if(allCakesSum < 1)
            {
                Console.WriteLine("{0:F22}", allCakesSum);
                Console.WriteLine("{0}/{1}", roundedNominator, denominator);
            }
            else
            {
                decimal valueRounded = Math.Round(allCakesSum, 0);
                Console.WriteLine("{0}", valueRounded);
                Console.WriteLine("{0}/{1}", roundedNominator, denominator);
            }
        }
    }
}
