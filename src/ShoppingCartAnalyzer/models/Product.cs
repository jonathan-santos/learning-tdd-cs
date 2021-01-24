namespace ShoppingCartAnalyzer
{
    public class Product
    {
        public string Name { get; }
        public double Value { get; }

        public Product(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
