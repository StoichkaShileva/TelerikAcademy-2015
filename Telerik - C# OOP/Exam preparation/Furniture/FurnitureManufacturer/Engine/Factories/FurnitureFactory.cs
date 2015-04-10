using System.Security.Principal;

namespace FurnitureManufacturer.Engine.Factories
{
    using System;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            Table t = new Table();
            t.Model = model;
            t.MaterialType = GetMaterialType(materialType);
            t.Price = price;
            t.Height = height;
            t.Length = length;
            t.Width = width;
            return t;
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            Chair currentChair = new Chair();
            currentChair.Model = model;
            currentChair.MaterialType = GetMaterialType(materialType);
            currentChair.Price = price;
            currentChair.Height = height;
            currentChair.NumberOfLegs = numberOfLegs;
            return currentChair;
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            AdjustableChair currentAdjustableChair = new AdjustableChair();
            currentAdjustableChair.Model = model;
            currentAdjustableChair.MaterialType = GetMaterialType(materialType);
            currentAdjustableChair.Price = price;
            currentAdjustableChair.Height = height;
            currentAdjustableChair.NumberOfLegs = numberOfLegs;
            return currentAdjustableChair;
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            ConvertibleChair currentConvertibleChair = new ConvertibleChair();
            currentConvertibleChair.Model = model;
            currentConvertibleChair.MaterialType = GetMaterialType(materialType);
            currentConvertibleChair.Price = price;
            currentConvertibleChair.Height = height;
            currentConvertibleChair.NumberOfLegs = numberOfLegs;
            return currentConvertibleChair;
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }
    }
}
