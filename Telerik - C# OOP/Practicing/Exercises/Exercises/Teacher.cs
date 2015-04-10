using System.Collections.Generic;

namespace Exercises
{
    using Exercises.Interfaces;
    public class Teacher : Class, ITeacher
    {
        public List<Subject> Subjects { get; private set; }
        public string Name { get; set; }
    }
}
