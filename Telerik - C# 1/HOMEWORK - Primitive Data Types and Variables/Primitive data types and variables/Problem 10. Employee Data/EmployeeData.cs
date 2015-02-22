using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Employee_Data
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstame = "Pesho";
            string lastname = "Peshov";
            int age = 25;
            char gender = 'm';
            long idNumber = 8306112507;
            Random num = new Random();
            int uniqueNum = num.Next(27560000, 27569999);
            Console.WriteLine(uniqueNum);
        }
    }
}
