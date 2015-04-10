namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Battles;

    public class BattleManagerExtended : BattleManager
    {
        private const int FirstArmyNumber = 1;
        private const int SecondArmyNumber = 2;
        private const int ThirdArmyNumber = 3;
        private readonly ICollection<ICreaturesInBattle> thirdArmyCreatures;
        public BattleManagerExtended(ICreaturesFactory creaturesFactory, ILogger logger)
            : base(creaturesFactory, logger)
        {
            this.thirdArmyCreatures = new List<ICreaturesInBattle>();
        }

        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            if (creatureIdentifier == null)
            {
                throw new ArgumentNullException("creatureIdentifier");
            }

            if (creaturesInBattle == null)
            {
                throw new ArgumentNullException("creaturesInBattle");
            }

            if (creatureIdentifier.ArmyNumber == FirstArmyNumber)
            {
                base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
            }
            else if (creatureIdentifier.ArmyNumber == SecondArmyNumber)
            {
                base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
            }
            else if (creatureIdentifier.ArmyNumber == ThirdArmyNumber)
            {
                this.thirdArmyCreatures.Add(creaturesInBattle);
            }
            else
            {
                throw new ArgumentException(
                    string.Format(CultureInfo.InvariantCulture, "Invalid ArmyNumber: {0}", creatureIdentifier.ArmyNumber));
            }
        }

        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            if (identifier.ArmyNumber == FirstArmyNumber)
            {
                return base.GetByIdentifier(identifier);
            }

            if (identifier.ArmyNumber == SecondArmyNumber)
            {
                return base.GetByIdentifier(identifier);
            }
            if (identifier.ArmyNumber == ThirdArmyNumber)
            {
                return this.thirdArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }

            throw new ArgumentException(
             string.Format(CultureInfo.InvariantCulture, "Invalid ArmyNumber: {0}", identifier.ArmyNumber));

        }
    }
}
