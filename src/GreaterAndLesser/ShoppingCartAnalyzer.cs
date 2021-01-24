namespace GreaterAndLesser
{
    public class ShoppingCartAnalyzer
    {
        public Product MostExpensive { get; private set; }
        public Product Cheapest { get; private set; }

        public ShoppingCartAnalyzer(ShoppingCart cart)
        {
            foreach (var product in cart.Products)
            {
                if (Cheapest == null || product.Value < Cheapest.Value)
                    Cheapest = product;
                if (MostExpensive == null || product.Value > MostExpensive.Value)
                    MostExpensive = product;
            }
        }
    }
}

