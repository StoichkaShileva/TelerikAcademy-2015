using System.ComponentModel;
using System.Xml.Schema;

namespace FuncAndAction
{
    using System;
    using System.Collections.Generic;

    public static class DoSomething
    {
        public static void MethodSSS(int a)
        {
            Console.WriteLine(a * a);
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public Student(string inputName)
        {
            this.Name = inputName;
        }

        public static void SayHello(string nameParam)
        {
            Console.WriteLine(nameParam);
        }
    }

    public delegate void Name(int a);
    public class FunctionsAndActions
    {
        public static void SpecialMethod(int a)
        {
            Console.WriteLine(a);
        }
        public static void SpecialMethodAddOneThousand(int a)
        {
            Console.WriteLine(a + 1000);
        }

        public static void MethodWithThreeArguments(string first, int second, Student third)
        {
            Console.WriteLine(first + " " + second + " " + third.Name);

        }

        public static string MagicMethod(int val)
        {
            return val.ToString() + " HOHOHO i botilka rom!";
        }

        public delegate int StringAndInt(string str);

        public delegate int Name(string val);

        public delegate void Action2<T, K>(T val1, K val2);

        public delegate T Func2<T,K>(T val1, K val2);
        public static void Main()
        {

            Action<int> someInts = new Action<int>(SpecialMethod);
            someInts += SpecialMethodAddOneThousand;
            someInts += DoSomething.MethodSSS;
            someInts(5);
            Console.Clear();

            Action<string, int, Student> runAll =
                new Action<string, int, FuncAndAction.Student>(MethodWithThreeArguments);

            runAll("yolo", 69, new Student("iok name"));

            Console.Clear();

            Func<int, string> funcWithReturn = new Func<int, string>(delegate(int a)
            {
                return a.ToString();
            });
            funcWithReturn += MagicMethod;


            Console.WriteLine(funcWithReturn(44));

            Console.Clear();

            StringAndInt abe = new StringAndInt(delegate(string val)
            {
                if (Char.IsDigit(val[0]))
                {
                    return int.Parse(val[0].ToString());
                }
                return -1;
            });
            Console.WriteLine(abe("xax5"));
            Console.Clear();
            Action2<int, string> ab = new Action2<int, string>(delegate(int a, string b)
            {
                Console.WriteLine((int)a + ' '.ToString() + b);
            });

            ab(1,"yehu!");
            Console.Clear();

            Func2<int, string> FuncOverride = new Func2<int, string>(delegate(int a, string str)
            {
                return 33;
            });

            Console.WriteLine(FuncOverride(33, "hu"));

        }
    }
}