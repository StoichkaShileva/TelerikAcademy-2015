using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    public interface IMouseLeft
    {
        int Scroll { get; set; }
        int Price { get; set; }
        int Something { get; set; }
        List<T> Method<T>(List<T> m);
        int this[int index] { get; set; }

        IEnumerable<T> Sp<T>(T[] arr);


    }
    public abstract class Mouse
    {
        public abstract int V(int a);

        public virtual int X(int xx)
        {
            return xx*(int) Math.PI;
        }
    }

    public class Setted : Mouse
    {
        public int Scroll { get; set; }
        public int I { get; set; }

        public override int V(int input)
        {
            return input + (int) Math.PI;
        }

        public override int X(int input)
        {
            this.I += input;
            return this.I;
        }

    }
    class StartProgram
    {
        static void Main()
        {
            Setted a = new Setted();
            a.I = 2233;
            a.X(444);
            Console.WriteLine(a.I);
        }
    }
}
