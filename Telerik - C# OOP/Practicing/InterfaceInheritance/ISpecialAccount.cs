namespace InterfaceInheritance
{
    public interface ISpecialAccount : IAccount
    {
        string Name { get; set; }
        void PrintName();
    }
}
