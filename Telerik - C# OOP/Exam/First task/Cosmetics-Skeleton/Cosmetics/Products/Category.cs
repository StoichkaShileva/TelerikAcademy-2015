namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private const int MinimumNameLength = 2;
        private const int MaximumNameLength = 15;
        private string name;
        private List<IProduct> cosmeticsList;

        public Category()
        {
            this.cosmeticsList = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < MinimumNameLength || value.Length > MaximumNameLength)
                {
                    throw new Exception(string.Format("Category name must be between {0} and {1} symbols long!",MinimumNameLength, MaximumNameLength));
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            cosmeticsList.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            bool result = cosmeticsList.Remove(cosmetics);
            if (result == false)
            {
                throw new Exception(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
        }

        public string Print()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("{0} category - {1} in total", this.Name, cosmeticsList.Count == 1 ? cosmeticsList.Count + " product" : cosmeticsList.Count + " products").Trim());
            foreach (var product in cosmeticsList.OrderBy(el => el.Brand).ThenByDescending(el => el.Price).ToList())
            {
                result.AppendLine(product.ToString().Trim());
            }
            return result.ToString().Trim();
        }
    }
}
