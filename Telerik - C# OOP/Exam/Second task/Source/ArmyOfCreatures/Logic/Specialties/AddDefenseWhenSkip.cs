namespace ArmyOfCreatures.Logic.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Battles;

    public class AddDefenseWhenSkip : Specialty
    {
        private readonly int points;

        public AddDefenseWhenSkip(int points)
        {
            if (points < 1 || points > 20)
            {
                throw new ArgumentOutOfRangeException("points", "points should be between 1 and 20, inclusive");
            }

            this.points = points;
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentDefense += this.points;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.points);
        }
    }
}
