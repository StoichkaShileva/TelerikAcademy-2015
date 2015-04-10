namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;
        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            set { this.numberOfLegs = value; }
        }

        public MaterialType MaterialType { get; set; }
        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}",
                this.GetType().Name, this.Model, this.MaterialType, this.Price, this.Height, this.NumberOfLegs);
        }
    }
}
