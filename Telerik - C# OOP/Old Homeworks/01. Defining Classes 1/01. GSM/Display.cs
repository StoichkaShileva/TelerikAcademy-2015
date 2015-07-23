namespace _01.GSM
{
    public class Display
    {
        private double? displaySize;
        private long? numberOfColors;

        public Display(double? displaySize, long? numberOfColorsInput)
        {
            this.Size = displaySize;
            this.Colors = numberOfColorsInput;
        }

        public Display(double? displaySize)
            : this(displaySize, null)
        {
            
        }

        public double? Size
        {
            get { return this.displaySize; }
            set { this.displaySize = value; }
        }

        public long? Colors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
    }
}
