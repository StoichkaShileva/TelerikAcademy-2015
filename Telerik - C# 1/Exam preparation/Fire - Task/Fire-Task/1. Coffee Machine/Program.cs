using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            double n1f = n1 * 0.05;
            double n2f = n2 * 0.10;
            double n3f = n3 * 0.20;
            double n4f = n4 * 0.50;
            double n5f = n5 * 1.00;

            double moneyInTheMachine = n1f + n2f + n3f + n4f + n5f;
            if(A > P && (A - P < moneyInTheMachine))
            {
                Console.WriteLine("Yes {0:F2}", moneyInTheMachine - (A - P));
            }
            else if(P > A)
            {
                Console.WriteLine("More {0:F2}", P - A);
            }
            else if(A > P && (A - P > moneyInTheMachine))
            {
                Console.WriteLine("No {0:F2}", (A - P - moneyInTheMachine));
            }

        }
    }
}
