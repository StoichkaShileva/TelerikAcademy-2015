using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    public class Person : ISpecialAccount
    {

        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }

        public decimal Money { get; set; }
    }
}
