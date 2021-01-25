using System.Collections.Generic;

namespace ShoppingCartAnalyzer
{
    public class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; }

        public ShoppingCart()
        {
            Items = new List<ShoppingCartItem>();
        }

        public void Add(Product product, int quantity)
        {
            Items.Add(new ShoppingCartItem(product, quantity));
        }
    }
}
