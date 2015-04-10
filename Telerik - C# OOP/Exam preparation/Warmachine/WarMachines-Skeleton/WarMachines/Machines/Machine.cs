namespace WarMachines.Machines
{
    using System.Collections.Generic;
    using WarMachines.Interfaces;
    public class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defencePoints;
        private IList<string> targets;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public IPilot Pilot
        {
            get { return this.pilot; }
            set { this.pilot = value; }
        }

        public double HealthPoints
        {
            get { return this.healthPoints; }
            set { this.healthPoints = value; }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
            set { this.attackPoints = value; }
        }

        public double DefensePoints
        {
            get { return this.defencePoints; }
            set { this.defencePoints = value; }
        }

        public IList<string> Targets
        {
            get
            {
                if (this.targets == null)
                {
                    this.targets = new List<string>();
                }
                return this.targets;
            }
        }

        public void Attack(string target)
        {
            targets.Add(target);
        }
    }
}
