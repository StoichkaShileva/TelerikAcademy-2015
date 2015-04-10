namespace Exercises.Interfaces
{
    using System.Collections.Generic;
    public interface ITeacher : IPerson
    {
        List<Subject> Subjects { get; }
        string Name { get; set; }
    }
}
