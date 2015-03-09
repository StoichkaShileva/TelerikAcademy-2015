using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastingBasicClasses
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            List<int> goshoMarks = new List<int>()
            {
                5,
                6,
                3,
                4,
                6,
                2
            };
            Random studentNumber = new Random();
            int num = studentNumber.Next(0, 10000000);
            Student gosho = new Student("Gosho", goshoMarks, num, 50);
            gosho.Points += 12;
            Console.WriteLine(gosho.Name);
            Console.WriteLine(gosho.Points);
            gosho.SayMood();
            gosho.Positive = false;
            gosho.SayMood();
            Student ivan = new Student();
            ivan.Name = "Vankata!";
            Console.WriteLine(ivan.Name);
            Student.NothingGood();
        }
    }
}
