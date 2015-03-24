using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var annonym = new
            {
                X = 331,
                Y = 100
            };
            var annonym2 = new
            {
                x = 1,
                Y = 100
            };


            var arrayAnnonymous = new[] 
            {
                new
                {
                    X=5, Y=10
                },
                new
                {
                    X = 444, Y=2333312
                }
            };
            var arr = new[] 
            { 
                new
                {
                    X = 3, Y = 5
                },
                new
                {
                    X = 1, Y = 2
                }
            };
            //Console.WriteLine(annonym.X);
            for (int i = 0; i < arrayAnnonymous.Length; i++)
            {
                Console.WriteLine(arrayAnnonymous[i].X);
            }
        }
    }
}
