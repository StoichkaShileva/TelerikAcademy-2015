using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurnkenNumbers
{
    class DrunkenNumbers
    {
        static void Main(string[] args)
        {
            //M for Mitko
            //V for Vladko
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            int beersForMitko = 0;
            int beersForVladko = 0;
            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                string secondValue = "";
                for (int q = 0; q < value.Length; q++)
                {
                    if(value[q] != '0')
                    {
                        secondValue += value[q];
                    }
                }
                if (secondValue.Length % 2 == 0)
                {
                    for (int j = 0; j < secondValue.Length / 2; j++)
                    {
                        if (j != '0')
                        {
                            beersForMitko += int.Parse(secondValue[j].ToString());
                        }
                    }
                    for (int j = secondValue.Length / 2; j < secondValue.Length; j++)
                    {
                        if (secondValue[j] != '0')
                        {
                            beersForVladko += int.Parse(secondValue[j].ToString());
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < (secondValue.Length / 2 + 1); j++)
                    {
                        if (secondValue[j] != '0')
                        {
                            beersForMitko += int.Parse(secondValue[j].ToString());
                        }

                    }
                    for (int j = secondValue.Length / 2; j < secondValue.Length; j++)
                    {
                        if (secondValue[j] != '0')
                        {
                            beersForVladko += int.Parse(secondValue[j].ToString());
                        }
                    }
                }
            }
            if(beersForMitko > beersForVladko)
            {
                Console.WriteLine("M {0}", beersForMitko - beersForVladko);
            }
            else if (beersForMitko < beersForVladko)
            {
                Console.WriteLine("V {0}", beersForVladko - beersForMitko);
            }
            else if(beersForMitko == beersForVladko)
            {
                Console.WriteLine("No {0}", beersForMitko + beersForVladko);
            }
        }
    }
}
