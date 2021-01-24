using NUnit.Framework;

namespace GreaterAndLesser
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

            var data = new ShoppingCartAnalyzer(cart);
            Assert.AreEqual(data.Cheapest.Name, "Set of Dishes");
            Assert.AreEqual(data.MostExpensive.Name, "Fridge");
        }

        [Test]
        public void AscendingOrder()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Set of Dishes", 70.00));
            cart.Add(new Product("Blender", 250.00));
            cart.Add(new Product("Fridge", 450.00));

            var data = new ShoppingCartAnalyzer(cart);
            Assert.AreEqual(data.Cheapest.Name, "Set of Dishes");
            Assert.AreEqual(data.MostExpensive.Name, "Fridge");
        }

        [Test]
        public void VariedOrder()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Blender", 250.00));
            cart.Add(new Product("Set of Dishes", 70.00));
            cart.Add(new Product("Fridge", 450.00));

            var data = new ShoppingCartAnalyzer(cart);
            Assert.AreEqual(data.Cheapest.Name, "Set of Dishes");
            Assert.AreEqual(data.MostExpensive.Name, "Fridge");
        }

        [Test]
        public void OneProduct()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Blender", 250.00));

            var data = new ShoppingCartAnalyzer(cart);
            Assert.AreEqual(data.Cheapest.Name, "Blender");
            Assert.AreEqual(data.MostExpensive.Name, "Blender");
        }
    }
}
