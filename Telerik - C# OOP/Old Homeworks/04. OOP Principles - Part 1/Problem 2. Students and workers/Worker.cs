/*
 * Define abstract class Human with first name and last name.
 * Define new class Student which is derived from Human and has new field – grade. 
 * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
 * Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
 * Initialize a list of 10 workers and sort them by money per hour in descending order.
 * Merge the lists and sort them by first name and last name.
*/
namespace Problem_2.Students_and_workers
{
    public class Worker : Human
    {
        private const int WEEK_DAYS = 7;
        public override string Firstname { get; set; }

        public override string Lastname { get; set; }

        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Worker(string inputFName, string inputLName, int inputWeekSalary, int inputWorkHours)
            : base(inputFName, inputLName)
        {
            this.WeekSalary = inputWeekSalary;
            this.WorkHoursPerDay = inputWorkHours;
        }

        public int MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay / WEEK_DAYS;
        }

        public override string ToString()
        {
            return "Money per hour: (" + this.MoneyPerHour() + ") Name -> " + this.Firstname + " " + this.Lastname;
        }
    }
}