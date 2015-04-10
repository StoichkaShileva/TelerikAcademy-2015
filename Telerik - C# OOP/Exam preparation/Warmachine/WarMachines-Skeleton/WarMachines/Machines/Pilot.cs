using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;
    public class Pilot : IPilot
    {
        private string name;
        private List<IMachine> machines;

        public Pilot()
        {
            this.machines = new List<IMachine>();
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<IMachine> Machines
        {
            get
            {
                if (this.machines == null)
                {
                    this.machines = new List<IMachine>();
                }
                return this.machines;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (this.machines == null)
            {
                this.machines = new List<IMachine>();
            }
            this.machines.Add(machine);
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("{0} - {1} {2}", this.Name, this.Machines.Count > 0 ? (this.Machines.Count.ToString()) : "no", this.Machines.Count != 1 ? "machines" : "machine"));
            //var specMachines = this.machines.OrderBy(_machine => _machine.HealthPoints).ThenBy(_machine => _machine.Name);
            var result = from machine in machines
                orderby machine.HealthPoints
                orderby machine.Name
                select machine;
            foreach (var machine in result)
            {
                sb.AppendLine();
                sb.Append(machine.ToString().Trim());
            }
            return sb.ToString();
        }
    }
}
