using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastingBasicClasses
{
    class Student
    {
        //Fields
        private const int area = 500;
        private string name;
        private List<int> marks;
        private int studentId;
        private int studentPoints;
        private bool isPositive = false;
        //Constructor
        public Student(string name, List<int> marks, int studentId, int points)
        {
            this.name = name;
            this.marks = marks;
            this.studentId = studentId;
            this.studentPoints = points;
        }

        public Student()
        {
            
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Points
        {
            get { return this.studentPoints; }
            set { this.studentPoints = value; }
        }

        public bool Positive
        {
            get { return this.isPositive; }
            set { this.isPositive = value; }
        }

        public void SayMood()
        {
            
            if (this.isPositive == true)
                Console.WriteLine("YEEEEEA!");
            else
                Console.WriteLine(":(((");
        }

        public static void NothingGood()
        {
            Console.WriteLine("lol, its static yeah!");
        }
    }
}
