using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;

        public ConvertibleChair()
        {
            this.IsConverted = false;
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
            private set { this.isConverted = value; }
        }

        public void Convert()
        {
            if (this.IsConverted == false)
            {
                this.Height = 0.10m;
                this.IsConverted = true;
            }
            else
            {
                this.Height = Height;
                this.IsConverted = false;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}",
                this.GetType().Name, this.Model, this.MaterialType, this.Price, this.Height, this.NumberOfLegs,
                this.IsConverted ? "Converted" : "Normal");
        }
    }
}
