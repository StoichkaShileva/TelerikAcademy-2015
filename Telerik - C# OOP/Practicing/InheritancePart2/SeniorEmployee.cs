namespace InheritancePart2
{
    public class SeniorEmployee : Employee
    {
        public int YearsOfExperience { get; set; }
        public override string ToString()
        {
            return base.Name + " " + base.EMail + " " + base.JobTitle + " " + base.EmployeeId + " " +
                   this.YearsOfExperience;
        }
    }
}