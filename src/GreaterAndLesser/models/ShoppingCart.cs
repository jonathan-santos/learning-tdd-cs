using System.Collections.Generic;

namespace GreaterAndLesser
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
