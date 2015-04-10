namespace WarMachines.Machines
{
    using WarMachines.Interfaces;
    using System.Collections.Generic;
    public class Tank : Machine, ITank
    {
        private bool isDefenceMode = true;
        public bool DefenseMode
        {
            get { return this.isDefenceMode; }
        }

        public void ToggleDefenseMode()
        {
            if (isDefenceMode == false)
            {

                isDefenceMode = true;
                this.DefensePoints -= 40;
                this.AttackPoints += 30;
            }
            else
            {
                isDefenceMode = false;
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
        }
//        public override string ToString()
//        {
////            return string.Format("*Type: (Tank)\r\n*Health: (" + this.HealthPoints + ")\r\n*Attack: ({" + this.AttackPoints + "})\r\n*Defence: ({" + this.DefensePoints + "})\r\n*Targets: ({" + (this.Targets.Count > 0 ? TargetsList(this.Targets) : "None") + "})\r\n*Defence: ({"+(isDefenceMode ? "ON" : "OFF")+"})");
//            return "11";
//        }
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
                "- {5}\r\n *Type: Tank\r\n *Health: {0}\r\n *Attack: {1}\r\n *Defense: {2}\r\n *Targets: {3}\r\n *Defense: {4}", this.HealthPoints, this.AttackPoints, this.DefensePoints, this.Targets.Count > 0 ? TargetsList(this.Targets) : "None", this.isDefenceMode == true ? "ON" : "OFF", this.Name);
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
