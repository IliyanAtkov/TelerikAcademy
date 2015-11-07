namespace FirstTwentyProductsInRange
{
    using System;

    public class Product : IComparable
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; private set; }

        public decimal Price { get; set; }

        public int CompareTo(object obj)
        {
            var otherProduct = obj as Product;
            if (otherProduct == null)
            {
                throw new InvalidOperationException("not Product");
            }
            if (this.Price > otherProduct.Price)
            {
                return 1;
            }
            else if (this.Price < otherProduct.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}