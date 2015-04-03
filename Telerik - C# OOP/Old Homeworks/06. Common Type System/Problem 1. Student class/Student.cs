using System;
using System.CodeDom;
using System.Runtime.CompilerServices;

namespace Problem_1.Student_class
{
    public class Student
    {
        private string firstname;
        private string middlename;
        private string lastname;
        private string ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private University university;
        private Course course;
        private Faculty faculty;
        private Specialty specialty;

        public Student(string inputFirstName, string inputLastName, string inputMobilePhone)
        {
            this.Firstname = inputFirstName;
            this.Lastname = inputLastName;
            this.MobilePhone = inputMobilePhone;
        }

        public Course Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }

        public string PermanentAddress
        {
            get { return permanentAddress; }
            set { permanentAddress = value; }
        }

        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public Faculty Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Specialty Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        public University University
        {
            get { return university; }
            set { university = value; }
        }

        
        public override bool Equals(object inputObj)
        {
            Student currentSt = inputObj as Student;
            if (currentSt.Firstname.Equals(this.Firstname))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname + " " + this.MobilePhone;
        }

        public static bool operator ==(Student first, Student second)
        {
            if (first.Equals(second))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Student first, Student second)
        {
            if (first.Equals(second))
            {
                return false;
            }
            return true;
        }


        public override int GetHashCode()
        {
            int hash = 6;
            hash = (hash*11) + this.Firstname.GetHashCode() / 2 * 643 + 71262 - 1;
            return hash;
        }

    }
}
