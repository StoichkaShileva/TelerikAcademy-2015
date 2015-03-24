using System;

namespace InheritancePart2
{
    class StartProgram
    {
        static void Main()
        {
            SeniorEmployee ivan = new SeniorEmployee();
            ivan.EMail = "ivan@a.bg";
            ivan.EmployeeId = "XXA@ED";
            ivan.YearsOfExperience += 8;
            ivan.Name = "Vankata";
            ivan.JobTitle = "Programmer";
            Console.WriteLine(ivan);
            
            //@

            Teacher t = new Teacher("Math");

            Console.WriteLine(t.Subject);
        }
    }
}