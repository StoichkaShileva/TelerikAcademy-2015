using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions_9to16_Students
{
    class MainClass
    {
        public static List<Student> students = new List<Student>()
        {
            new Student("Ali", "Raza","45432342","+359999994444", "lo6omie@abv.bg", 1 , 2, 2, 5, 5, 4, 2),
            new Student("Boiko", "Borisov","54232342", "+359343999333", "filiqSmas@abv.bg", 2 , 2, 2, 2, 2),
            new Student("Gosho", "Selskiq","56424242","+359439999325", "otSeloSum69@abv.bg", 2 , 2, 3, 4, 3),
            new Student("Pesho", "Ahmaka","43242323","+359459999236", "budalata99@gmail.bg", 3, 2, 2, 3, 4, 6, 1),
            new Student("Gencho", "Abdala", "34243211","+359499995675", "kakoitui@abv.bg", 3 , 2, 2, 3, 4),
        };

        static void Main()
        {
            //Undo comment to see results!!!!
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            //Task13();
            Task14();
            //Task15();
            //Task16();
        }

        private static void Task16()
        {
            List<StudentGroups> groups = new List<StudentGroups>()
            {
                new StudentGroups(1, "Physics"),
                new StudentGroups(2, "Mathematics"),
                new StudentGroups(3, "Maths"),
                new StudentGroups(4, "Computer Science"),
                new StudentGroups(5, "Medicine"),
                new StudentGroups(6, "Biology"),
            };

            var studentsFromMathematics = students
                .Join(groups, st => st.GroupNumber, gr => gr.GroupNumber,
                (st, gr) => new
                {
                    Student = st,
                    Group = gr,
                })
                .Where(mat => mat.Group.DepartmentName == "Mathematics");

            foreach (var st in studentsFromMathematics)
            {
                Console.WriteLine(st);
            }
        }

        private static void Task15()
        {
            var enrolledIn2006Marks = students
                .Where(st => st.FN.Substring(4, 2) == "06");

            foreach (var st in enrolledIn2006Marks)
            {
                Console.WriteLine(string.Join(", ", st.Marks));
            }
        }

        private static void Task14()
        {
            var exactMarkTwoTimes = students.GetStudentWithMarkExactTimes(2, 2);

            Print(exactMarkTwoTimes);
        }

        private static void Task13()
        {
            var atLeastOne6 = students
                .Where(st => st.Marks.Contains(6))
                .Select(st => new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = st.Marks
                });

            foreach (var st in atLeastOne6)
            {
                Console.WriteLine(st.FullName + "'s marks: " + string.Join(", ", st.Marks));
            }
        }

        private static void Task12()
        {
            var fromSofia = students
                .Where(st => st.Tel.StartsWith("+3592") || st.Tel.StartsWith("02"));
            Print(fromSofia);
        }

        private static void Task11()
        {
            var studentsWithEmailInABV = students
                .Where(st => st.Email.Contains("abv.bg"));

            Print(studentsWithEmailInABV);
        }

        private static void Task10()
        {
            var studentsFromGroup = students.GetStudentsFromGroup(2);
            Print(studentsFromGroup);
        }

        private static void Task9()
        {
            var studentsFromGroupTwo = students
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName);
            Print(studentsFromGroupTwo);
        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine(st);
            }
        }
    }
}
