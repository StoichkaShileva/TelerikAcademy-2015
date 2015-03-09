using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TastingBasicClasses
{
    public class Person
    {
        //Fields
        private int age;
        private string name;
        private bool isRasist;

        //Constructor
        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
            this.isRasist = false;
        }

        //Properties

        public string Name
        {
            get
            {
                return this.name; 
                
            }
            set
            {
                this.name = value;
            }
        }

        public string CheckIsRasist
        {
            get
            {
                string isRasist = string.Empty;
                isRasist = this.isRasist ? "yeah" : "no";
                return isRasist;
            }
            set
            {
                if (value == "yes")
                {
                    this.isRasist = true; 
                }
                else if (value == "no")
                {
                    this.isRasist = false;
                }
                
                
            }
        }
    }
}
