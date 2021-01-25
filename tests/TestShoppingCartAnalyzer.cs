using NUnit.Framework;

namespace ShoppingCartAnalyzer
{
    public class TestShoppingCartAnalyzer
    {
        [Test]
        public void DecreasingOrder()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Fridge", 450.00), 1);
            cart.Add(new Product("Blender", 250.00), 1);
            cart.Add(new Product("Set of Dishes", 70.00), 1);

            var (leastExpensive, mostExpensive) = Analyzer.GetMostExpensiveAndLeastExpensiveProducts(cart);
            Assert.AreEqual("Set of Dishes", leastExpensive.Name);
            Assert.AreEqual("Fridge", mostExpensive.Name);
        }

        [Test]
        public void AscendingOrder()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Set of Dishes", 70.00), 1);
            cart.Add(new Product("Blender", 250.00), 1);
            cart.Add(new Product("Fridge", 450.00), 1);

            var (leastExpensive, mostExpensive) = Analyzer.GetMostExpensiveAndLeastExpensiveProducts(cart);
            Assert.AreEqual("Set of Dishes", leastExpensive.Name);
            Assert.AreEqual("Fridge", mostExpensive.Name);
        }

        [Test]
        public void VariedOrder()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Blender", 250.00), 1);
            cart.Add(new Product("Set of Dishes", 70.00), 1);
            cart.Add(new Product("Fridge", 450.00), 1);

            var (leastExpensive, mostExpensive) = Analyzer.GetMostExpensiveAndLeastExpensiveProducts(cart);
            Assert.AreEqual("Set of Dishes", leastExpensive.Name);
            Assert.AreEqual("Fridge", mostExpensive.Name);
        }

        [Test]
        public void OneProduct()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Blender", 250.00), 1);

            var (leastExpensive, mostExpensive) = Analyzer.GetMostExpensiveAndLeastExpensiveProducts(cart);
            Assert.AreEqual("Blender", leastExpensive.Name);
            Assert.AreEqual("Blender", mostExpensive.Name);
        }
    }
}
