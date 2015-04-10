namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;
        public decimal Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public decimal Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public decimal Area
        {
            get { return this.Length*this.Height; }
        }

        public override string ToString()
        {
            return
                string.Format(
                    "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}",
                    this.GetType().Name, this.Model, this.MaterialType, this.Price, this.Height, this.Length, this.Width,
                    this.Area);
        }

        public MaterialType MaterialType { get; set; }
    }
}
