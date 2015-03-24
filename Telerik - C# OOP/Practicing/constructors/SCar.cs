namespace constructors
{
    public sealed class SCar : Car
    {
        public string S { get; set; }

        public SCar()
            : base()
        {
            
        }
        public SCar(string inputEngine, int? inputHP = null, int? inputWeight = null)
            : base(inputEngine, inputHP, inputWeight)
        {
        }

    }
}