﻿namespace StudentsGroup
{

    public class Group
    {

        public int GroupNumber { get; private set; }
        public string DepartmentName { get; private set; }
        public Group(int number, string name)
        {
            this.GroupNumber = number;
            this.DepartmentName = name;
        }
    }
}
