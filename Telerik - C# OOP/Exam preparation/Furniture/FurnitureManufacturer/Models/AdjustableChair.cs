namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class AdjustableChair : Chair, IAdjustableChair
    {
        public void SetHeight(decimal height)
        {
            this.Height = height;
        }

        public int NumberOfLegs
        {
            get { return base.NumberOfLegs; }
            set { base.NumberOfLegs = value; }
        }
    }
}
