using System;
using System.CodeDom;

namespace Empty
{
    public class Test : IComparable<Test>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Test(string inputName, int inputAge)
        {
            this.Name = inputName;
            this.Age = inputAge;
        }

        public static bool operator ==(Test first, Test second)
        {
            return Object.Equals(first, second);
        }

        public static bool operator !=(Test first, Test second)
        {
            return !(Object.Equals(first, second));
        }

        public static bool operator +(Test f, Test s)
        {
            return f.Equals(s);
        }

        public override bool Equals(Object f)
        {
            Test castObj = f as Test;
            if (castObj == null)
                return false;
            return castObj.Age == this.Age
                   && castObj.Name == this.Name;
        }
        public int CompareTo(Test other)
        {
            if (other.Age > this.Age)
                return -1;
            else if (this.Age > other.Age)
                return 1;
            else
                return 0;
        }
    }
}