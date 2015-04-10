using System;

namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    public abstract class Furniture : IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;
        public virtual string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException();
                }
                else if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public virtual string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public virtual decimal Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.height = value;
                }
            }
        }
    }
}
