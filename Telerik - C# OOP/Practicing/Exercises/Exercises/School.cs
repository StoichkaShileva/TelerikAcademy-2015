namespace Exercises
{
    using System.Collections.Generic;
    using Exercises.Interfaces;
    public class School : ISchool
    {
        private List<Class> classes;

        public List<Class> Classes
        {
            get { return this.classes; }
        } 
    }
}
