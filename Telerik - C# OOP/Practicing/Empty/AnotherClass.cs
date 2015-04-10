namespace Empty
{
    public class AnotherClass : Test
    {
        public string Something { get; set; }

        public AnotherClass(string inputName, int inputAge, string inputSomething)
            : base (inputName, inputAge)
        {
            this.Something = inputSomething;
        }

    }
}
