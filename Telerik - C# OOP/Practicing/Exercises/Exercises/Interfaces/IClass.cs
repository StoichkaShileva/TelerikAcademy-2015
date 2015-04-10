namespace Exercises.Interfaces
{
    using System.Collections.Generic;
    public interface IClass
    {
        List<IStudent> Students { get; }
        List<ITeacher> Teachers { get; }
        string UniqueTextID { get; set; }
    }
}
