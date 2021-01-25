namespace ShoppingCartAnalyzer
{
    public class ShoppingCartItem
    {
        public Product Product { get; }
        public int Quantity { get; }
        public double TotalValue => this.Product.Value * this.Quantity;

        public ShoppingCartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
    }
}
