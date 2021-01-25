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

        public (Product LeastExpensive, Product MostExpensive) GetMostExpensiveAndLeastExpensiveProducts()
        {
            Product leastEspensive = null;
            Product mostExpensive = null;

            foreach (var item in this.Items)
            {
                if (leastEspensive == null || item.Product.Value < leastEspensive.Value)
                    leastEspensive = item.Product;
                if (mostExpensive == null || item.Product.Value > mostExpensive.Value)
                    mostExpensive = item.Product;
            }

            return (leastEspensive, mostExpensive);
        }
    }
}
