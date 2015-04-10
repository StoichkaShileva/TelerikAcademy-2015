namespace ArmyOfCreatures.Extended.Specialties
{
    using System;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Specialties;

    public class DoubleDamage : Specialty
    {
        private const int MinimumNumberOfRounds = 0;
        private const int MaximumNumberOfRounds = 10;
        private const int Multiply = 2;
        private int numberOfRounds;
        public DoubleDamage(int inputNumberOfRounds)
        {
            this.NumberOfRounds = inputNumberOfRounds;
        }

        public int NumberOfRounds
        {
            get { return numberOfRounds; }
            set
            {
                if (value <= MinimumNumberOfRounds || value > MaximumNumberOfRounds)
                {
                    throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
                }
                else
                {
                    numberOfRounds = value;
                }
            }
        }
        public override decimal ChangeDamageWhenAttacking(
            ICreaturesInBattle attackerWithSpecialty,
            ICreaturesInBattle defender,
            decimal currentDamage)
        {
            if (this.numberOfRounds > MinimumNumberOfRounds)
            {
                this.numberOfRounds--;
                return currentDamage * Multiply;
            }
            return currentDamage;
        }
        public override string ToString()
        {
            return "DoubleDamage(" + NumberOfRounds + ")";
        }
    }
}
