namespace ShoppingCartAnalyzer
{
    public class Analyzer
    {
        public static (Product, Product) GetMostExpensiveAndLeastExpensiveProducts(ShoppingCart cart)
        {
            Product leastEspensive = null;
            Product mostExpensive = null;

            foreach (var item in cart.Items)
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

