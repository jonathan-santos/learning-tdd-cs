using System.Collections.Generic;

namespace ShoppingCartAnalyzer
{
    public class ShoppingCart
    {
        public List<Product> Products { get; }

        public ShoppingCart()
        {
            Products = new List<Product>();
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }
    }
}
