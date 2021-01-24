using NUnit.Framework;

namespace ShoppingCartAnalyzer
{
    public class TestShoppingCartAnalyzer
    {
        [Test]
        public void DecreasingOrder()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Fridge", 450.00));
            cart.Add(new Product("Blender", 250.00));
            cart.Add(new Product("Set of Dishes", 70.00));

            var data = new Analyzer(cart);
            Assert.AreEqual("Set of Dishes", data.Cheapest.Name);
            Assert.AreEqual("Fridge", data.MostExpensive.Name);
        }

        [Test]
        public void AscendingOrder()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Set of Dishes", 70.00));
            cart.Add(new Product("Blender", 250.00));
            cart.Add(new Product("Fridge", 450.00));

            var data = new Analyzer(cart);
            Assert.AreEqual("Set of Dishes", data.Cheapest.Name);
            Assert.AreEqual("Fridge", data.MostExpensive.Name);
        }

        [Test]
        public void VariedOrder()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Blender", 250.00));
            cart.Add(new Product("Set of Dishes", 70.00));
            cart.Add(new Product("Fridge", 450.00));

            var data = new Analyzer(cart);
            Assert.AreEqual("Set of Dishes", data.Cheapest.Name);
            Assert.AreEqual("Fridge", data.MostExpensive.Name);
        }

        [Test]
        public void OneProduct()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Blender", 250.00));

            var data = new Analyzer(cart);
            Assert.AreEqual("Blender", data.Cheapest.Name);
            Assert.AreEqual("Blender", data.MostExpensive.Name);
        }
    }
}
