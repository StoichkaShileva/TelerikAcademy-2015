namespace Exercises
{
    using Exercises.Interfaces;

    public class Subject : Class, ISubject
    {

        public string Name { get; set; }

        public int NumberOfClasses { get; set; }

        public int NumberOfExercises { get; set; }
    }
}
