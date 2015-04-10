using System.Linq;
using System.Text;
namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using FurnitureManufacturer.Interfaces;
    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException();
                }
                else if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            set
            {
                if (value.Length == 10)
                {
                    bool isDigit = true;
                    foreach (var letter in value)
                    {
                        if (!Char.IsDigit(letter))
                        {
                            isDigit = false;
                            break;
                        }
                    }
                    if (isDigit == false)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        this.registrationNumber = value;
                    }
                }
                else
                {
                    this.registrationNumber = value;
                }
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                if (this.furnitures == null)
                {
                    this.furnitures = new List<IFurniture>();
                    return this.furnitures;
                }
                return this.furnitures;
            }
        }

        public void Add(IFurniture furniture)
        {
            if (this.furnitures == null)
            {
                this.furnitures = new List<IFurniture>();
            }
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            if (this.furnitures.Contains(furniture))
            {
                this.furnitures.Remove(furniture);
            }
        }

        public IFurniture Find(string model)
        {
            return furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} - {1} - {2} {3}",
                    Name,
                    RegistrationNumber,
                    Furnitures.Count != 0 ? Furnitures.Count.ToString() : "no",
                    Furnitures.Count != 1 ? "furnitures" : "furniture").Trim());

            //foreach (var furniture in this.Furnitures)
            //{

            //    if (furniture is ITable)
            //    {
            //        sb += "\r\n";
            //        Table currentTable = furniture as Table;
            //        sb += (string.Format("Type: {0}, Model: {1}, Material: {2}, " +
            //                             "Price: {3}, Height: {4}, Length: {5}, Width: {6}, " +
            //                             "Area: {7}", currentTable.GetType().Name, currentTable.Model,
            //                             currentTable.Material, currentTable.Price, currentTable.Height, currentTable.Length,
            //                             currentTable.Width, currentTable.Area));
            //    }
            //    else if (furniture is IConvertibleChair)
            //    {
            //        sb += "\r\n";
            //        ConvertibleChair currentConvertibleChair = furniture as ConvertibleChair;
            //        sb += (
            //            string.Format(
            //                "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}",
            //                currentConvertibleChair.GetType().Name, currentConvertibleChair.Model, currentConvertibleChair.Material, currentConvertibleChair.Price, currentConvertibleChair.Height, currentConvertibleChair.NumberOfLegs,
            //                currentConvertibleChair.IsConverted ? "Converted" : "Normal"));
            //    }
            //    else if (furniture is IChair)
            //    {
            //        sb += "\r\n";
            //        Chair currentChair = furniture as Chair;
            //        sb += (
            //            string.Format(
            //                "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}", currentChair.GetType().Name, currentChair.Model, currentChair.Material, currentChair.Price, currentChair.Height, currentChair.NumberOfLegs));
            //    }
            //}
            foreach (var furniture in this.Furnitures.OrderBy(furniture => furniture.Price).ThenBy(furniture => furniture.Model))
            {
                sb.AppendLine(furniture.ToString().Trim());
            }
            return sb.ToString().Trim();
        }
    }
}