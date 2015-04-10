namespace Infestation
{
    public class Weapon : ISupplement
    {
        private int weaponPowerEffect = 10;
        private int weaponAgressionEffect = 3;

        public void ReactTo(ISupplement otherSupplement)
        {
            throw new System.NotImplementedException();
        }

        public int PowerEffect
        {
            get
            {
                return this.PowerEffect + weaponPowerEffect;
            }
        }

        public int HealthEffect
        {
            get { return this.HealthEffect; }
        }

        public int AggressionEffect
        {
            get { return this.AggressionEffect + weaponAgressionEffect; }
        }
    }
}
