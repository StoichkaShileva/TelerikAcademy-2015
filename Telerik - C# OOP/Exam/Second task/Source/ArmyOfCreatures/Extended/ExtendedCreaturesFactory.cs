namespace ArmyOfCreatures.Extended
{
    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Extended.Creatures;

    public class ExtendedCreaturesFactory : CreaturesFactory
    {
        private const string AncientBehemoth = "AncientBehemoth";
        private const string CyclopsKing = "CyclopsKing";
        private const string Goblin = "Goblin";
        private const string Griffin = "Griffin";
        private const string WolfRaider = "WolfRaider";
        public override Creature CreateCreature(string name)
        {
            switch (name)
            {
                case AncientBehemoth:
                    return new AncientBehemoth();
                    break;
                case CyclopsKing:
                    return new CyclopsKing();
                    break;
                case Goblin:
                    return new Goblin();
                    break;
                case Griffin:
                    return new Griffin();
                    break;
                case WolfRaider:
                    return new WolfRaider();
                    break;
            }
            return base.CreateCreature(name);
        }
    }
}
