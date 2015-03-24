using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace staticMembers
{
    public class DoSomething
    {
        public string prop { get; set; }
        private string name;

        public DoSomething(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }
        public static DoSomething operator +(DoSomething a, DoSomething b)
        {
            return new DoSomething(a.name + " " + b.name);
        }
        public static void Print<T>(T val)
        {
            Console.WriteLine(val);
        }
    }
    public class StartProgram
    {
        static void Main()
        {
            DoSomething something = new DoSomething("ivan");
            DoSomething doSomethingAgain = new DoSomething("gogo");
            DoSomething c = something + doSomethingAgain;
            Console.WriteLine(c.Name);
        }
    }
}
