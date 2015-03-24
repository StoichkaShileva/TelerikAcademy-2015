using System.CodeDom;
using Microsoft.Win32;

namespace LinqAndLambda
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class DoSomething
    {
        
       
        public static void Print<T>(List<T> val)
        {
            for (int i = 0; i < val.Count; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
    }

    public class Person
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        


        //public Person(string nameInput, int ageInput, string genderInput)
        //{
        //    this.Name = nameInput;
        //    this.Age = ageInput;
        //    this.Gender = genderInput;
        //}
        public override string ToString()
        {
            return string.Format("{0} is {2} and he/she is {1} years old.", this.Name, this.Age, this.Gender);
        }
    }
    class LinqAndLambda
    {
        static void Main()
        {
            List<int> ints = new List<int>();
            Random rand = new Random();
            for (int i = 50; i > 1; i-=4)
            {
                //int current = rand.Next(int.MinValue, int.MaxValue);
                ints.Add(i);
            }
            List<int> newCollection = ints.FindAll(delegate(int val)
            {
                if (val%2 == 0) return true;
                else
                {
                    return false;
                }
            });
            DoSomething.Print(newCollection);

            Console.Clear();
            var people = new Person[]
            {
                new Person
                {
                    Name = "pesho",
                    Age = 15,
                    Gender = "kuche"
                },
                new Person
                {
                    Name = "alex",
                    Age = 105,
                    Gender = "ludak"
                },
                new Person
                {
                    Name = "ivko",
                    Age = 55,
                    Gender = "muj"
                },
            };
            var result = people.OrderByDescending(person => person.Age);
            foreach (var person in result)
            {
                Console.WriteLine(person.Age);
            }
            Console.Clear();

            var r = people.Max(person => person.Age);
            Console.WriteLine(r);

            Console.Clear();

            var res = people.Where(person => person.Age > 20)
                .OrderBy(person => person.Name)
                .ToList();
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.Clear();

            var resAgain = people.Where(person => person.Gender.Length > 5);
            foreach (var person in resAgain)
            {
                Console.WriteLine(person);
            }
            Console.Clear();
            var result100 = people.Last(x => x.Gender[1] == 'u');
            Console.WriteLine(result100);

        }
    }
}
