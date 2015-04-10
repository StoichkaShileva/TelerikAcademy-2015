namespace Exercises
{
    using Exercises.Interfaces;
    public interface IStudent : IPerson
    {
        string Name { get; set; }
        string UniqueID { get; set; }
    }
}
