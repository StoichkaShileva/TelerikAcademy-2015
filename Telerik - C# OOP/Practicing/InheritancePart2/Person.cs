using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePart2
{
    public class Person
    {
        public string EMail { get; set; }
        public string Name { get; set; }

        public Person() : this(null, null)
        {
        }

        public Person(string name) : this(name, null)
        {
            
        }
        public Person(string inputName, string inputEmail)
        {
            this.EMail = inputEmail;
            this.Name = inputName;
        }
    }
}
