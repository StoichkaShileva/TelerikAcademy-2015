using System.Security.Cryptography.X509Certificates;

namespace testingPartTwo
{

    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Remoting;
    using System.Text;
    using System.Threading.Tasks;
    using ivan = SpecialThings;
    public class ListSpec<T>
    {
        private T[] elements = new T[20];
        private int counter = 20;
        private int maxLength = 20;
        private int indexer = 0;
        public void AddEl(T num)
        {
            this.elements[indexer] = num;
            indexer++;
            counter++;
        }

        //public T this[int index]
        //{
        //    get
        //    {
        //        if(index > counter || index < 0)
        //            throw new IndexOutOfRangeException("Index is out of the special list!");
        //        else
        //        {
        //            return this.elements[index];
        //        }
        //    }
        //    set
        //    {
        //        if (index > counter || index < 0)
        //            throw new IndexOutOfRangeException("Index is out of the special list!");
        //        else
        //        {
        //            this.elements[index] = value;
        //        }
        //    }
        //}

        //public T GetVal(int index)
        //{
        //    if(index < counter)
        //        return this.elements[index];
        //    else 
        //        throw new IndexOutOfRangeException("Index is out of special list range.");
        //}
        public int Length
        {
            get { return this.counter; }

        }

        public T this[int index]
        {
            get { return elements[index]; }
            set { this.elements[index] = value; }
        }
    }

    public class OnlyForSpecialReturn
    {
        public static string HappyMethod()
        {
            return "Yeah, i am happy! = )";
        }
    }
    public class Person
    {
        private string name;
        private static string pop = "Yeah this is a function ... something here..";



        public Person(string inputName)
        {
            this.Name = inputName;
        }


        public static string Pop
        {
            get { return pop; }
            set { pop = value; }
        }

        public static int ReturnHappyNumber()
        {
            Random happyNum = new Random();
            int num = happyNum.Next(0, int.MaxValue);
            return num;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 50 && value.Length > 3)
                {
                    this.name = value;
                    throw new ArgumentException("Name must be more than 3 sybols and less than 50 symbols.");
                }
            }
        }
    }

    public struct SpecialStruct
    {
        private int[] marks;

        public int[] Marks
        {
            get { return this.marks; }
            set
            {
                if (value.Length > 0)
                {
                    marks = value;
                }
            }
        }
    }

    class TestingThings
    {
        static void ShowMarksToStudents(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += i;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");

            //string input = Console.ReadLine();
            //Person newPerson = new Person(input);
            //Console.Write("Congratulations! Your happy number is: ");
            //Console.WriteLine(Person.ReturnHappyNumber());

            ///STRUCT!
            //int[] arr = new int[20];
            //Random current = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = current.Next(0, arr.Length);
            //}
            //SpecialStruct saveSpecialNums = new SpecialStruct();
            //saveSpecialNums.Marks = arr;
            //foreach (var saveSpecialNum in saveSpecialNums.Marks)
            //{
            //    Console.WriteLine(saveSpecialNum);
            //}
            //ShowMarksToStudents(arr);
            //Console.WriteLine(new string('*', 50));
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            ///GENERIC LIST ->
            ListSpec<int> intSpec = new ListSpec<int>();
            //intSpec.AddEl(5);
            Console.WriteLine(intSpec.Length);
            intSpec.AddEl(5);
            Console.WriteLine(intSpec[0]);
            intSpec[0] = 55;
            Console.WriteLine(intSpec[0]);
            //Console.WriteLine(intSpec.GetVal(1231));

            //ListSpec<string> vals = new ListSpec<string>();
            //vals.AddEl("yeeeeh!");
            //Console.WriteLine(vals.GetVal(0));
            //Console.WriteLine(vals.Length);

        }
    }
}
