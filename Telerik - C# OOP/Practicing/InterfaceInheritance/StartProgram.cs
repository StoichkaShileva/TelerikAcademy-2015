namespace InterfaceInheritance
{
    using System;
    using InterfaceInheritance.SomethingIN;
    using InterfaceInheritance.AnotherShit.LOOW.Ivan;
    public class Kid : ISuperable
    {
        public string Name { get; set; }
    }
    public class StartProgram
    {
        public static void Main()
        {
            Console.WriteLine(CalculateTwoNums.Calculate(2,333));
        }
    }
}
