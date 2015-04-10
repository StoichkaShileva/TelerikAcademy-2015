namespace Infestation
{
    using System.Collections.Generic;
    public class Tank : Unit
    {
        const int TankPower = 25;
        const int TankAggression = 25;
        const int TankHealth = 20;
        public Tank(string id)
            : base(id, Infestation.UnitClassification.Mechanical, TankHealth, TankPower, TankAggression)
        {

        }
    }
}
