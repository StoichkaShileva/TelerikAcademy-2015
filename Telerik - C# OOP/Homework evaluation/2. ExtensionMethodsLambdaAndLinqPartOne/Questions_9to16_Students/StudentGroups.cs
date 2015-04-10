namespace Questions_9to16_Students
{
    public class StudentGroups
    {
        public StudentGroups(ulong numberOfGroup, string nameOfDepartment)
        {
            this.GroupNumber = numberOfGroup;
            this.DepartmentName = nameOfDepartment;
        }

        public ulong GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public override string ToString()
        {
            return this.DepartmentName;
        }
    }
}
