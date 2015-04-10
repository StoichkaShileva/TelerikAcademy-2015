namespace WarMachines.Engine
{
    using WarMachines.Interfaces;
    using WarMachines.Machines;

    public class MachineFactory : IMachineFactory
    {
        public IPilot HirePilot(string name)
        {
            Pilot pil = new Pilot() {Name = name};
            return pil;
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            Tank tank = new Tank();
            tank.Name = name;
            tank.AttackPoints = attackPoints;
            tank.DefensePoints = defensePoints;
            return tank;
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            Fighter figh = new Fighter();
            figh.Name = name;
            figh.AttackPoints = attackPoints;
            figh.DefensePoints = defensePoints;
            figh.StealthMode = stealthMode;
            return figh;
        }
    }
}
