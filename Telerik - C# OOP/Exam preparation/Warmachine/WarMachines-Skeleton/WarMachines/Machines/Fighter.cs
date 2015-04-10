using System.Collections.Generic;
using System.Reflection;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;
    public class Fighter : Machine, IFighter
    {
        private bool isStealthMode;
        public Fighter()
        {
            this.HealthPoints = 200;
        }
        public bool StealthMode
        {
            get { return this.isStealthMode; }
            set { this.isStealthMode = value; }
        }

        public void ToggleStealthMode()
        {
            if (this.isStealthMode == false)
            {
                this.isStealthMode = true;
            }
            else
            {
                this.isStealthMode = true;
            }
        }

        public override string ToString()
        {
            /*
             *Type: (“Tank”/”Fighter”)
             *Health: (machine health points)
             *Attack: (machine attack points)
             *Defense: (machine defense points)
             *Targets: (machine target names/”None” – comma separated)
             *Defense: (“ON”/”OFF” – when applicable)
             */
            return
                string.Format(
               "- {5}\r\n *Type: Tank\r\n *Health: {0}\r\n *Attack: {1}\r\n *Defense: {2}\r\n *Targets: {3}\r\n *Defense: {4}", this.HealthPoints, this.AttackPoints, this.DefensePoints, this.Targets.Count > 0 ? TargetsList(this.Targets) : "None", this.isStealthMode == true ? "ON" : "OFF", this.Name);
        }

        private string TargetsList(IList<string> list)
        {
            string st = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    st += list[i];
                }
                else
                {
                    st += list[i] + ", ";
                }
            }
            return st;
        }
        
    }
}
