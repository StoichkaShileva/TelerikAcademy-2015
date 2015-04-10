/*
 * Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
 */
namespace Problem_2.IClonable
{
    using System;
    public class StartProgram
    {
        public static void Main()
        {
            //Creating sample instance of student
            Student student = new Student();
            student.Age = 11;
            student.Name = "Pesho";
            student.Gender = "female";

            //Here we clone the object 'student'
            Student anotherStudent = (Student) student.Clone();

            //Printing into console
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Original student name: {0}", student.Name);
            Console.WriteLine("Original student age: {0}", student.Age);
            Console.WriteLine("Original student gender: {0}", student.Gender);
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Copied student name: {0}", anotherStudent.Name);
            Console.WriteLine("Copied student age: {0}", anotherStudent.Age);
            Console.WriteLine("Copied student gender: {0}", anotherStudent.Gender);
            Console.WriteLine(new string('=', 20));

        }
    }
}
