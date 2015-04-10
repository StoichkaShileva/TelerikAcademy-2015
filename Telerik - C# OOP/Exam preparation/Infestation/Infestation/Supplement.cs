namespace Infestation
{
    public abstract class Supplement : ISupplement
    {

        public Supplement(int inputPowerEffect, int inputHealthEffect, int inputAgressionEffect)
        {
            this.PowerEffect = inputPowerEffect;
            this.HealthEffect = inputHealthEffect;
            this.AggressionEffect = inputAgressionEffect;
        }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
            throw new System.NotImplementedException();
        }

        public virtual int PowerEffect { get; protected set; }

        public virtual int HealthEffect { get; protected set; }

        public virtual int AggressionEffect { get; protected set; }
    }
}
