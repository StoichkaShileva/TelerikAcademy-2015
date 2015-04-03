/*
 Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
 Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 */

namespace Problem_1.Student_class
{
    using System;
    public class StartProgram
    {
        public static void Main()
        {
            Student st = new Student("Ivan", "Draganov", "088877272");
            Student st2 = new Student("Ivan", "aaa", "088877272");
            //Using overridden equals (now comapres by firstname)
            Console.WriteLine("##### Comapring student #1 with student #2 with overridden Equals() #####");
            Console.WriteLine(st.Equals(st2));
            Console.WriteLine("##### Overridden ToString() for student #1 #####");
            //Using overridden ToString()
            Console.WriteLine(st.ToString());

            //Hashcode for student #1
            Console.WriteLine("##### Hashcode for student #1 #####");
            Console.WriteLine(st.GetHashCode());
            //Hashcode for student #2
            Console.WriteLine("##### Hashcode for student #2 #####");
            Console.WriteLine(st2.GetHashCode());

            Console.WriteLine("##### Comapring student #1 with student #2 via ( == ) #####");

            Console.WriteLine(st == st2);

            Console.WriteLine("##### Comapring student #1 with student #2 via ( != ) #####");

            Console.WriteLine(st != st2);

        }
    }
}

