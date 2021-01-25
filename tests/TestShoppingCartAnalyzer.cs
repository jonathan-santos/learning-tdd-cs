using NUnit.Framework;

namespace ShoppingCartAnalyzer
{
    public class TestShoppingCartAnalyzer
    {
        [Test]
        public void DecreasingOrderMostExpensiveAndLeastExpensiveProducts()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Fridge", 450.00), 1);
            cart.Add(new Product("Blender", 250.00), 1);
            cart.Add(new Product("Set of Dishes", 70.00), 1);

            var data = cart.GetMostExpensiveAndLeastExpensiveProducts();
            Assert.AreEqual("Set of Dishes", data.LeastExpensive.Name);
            Assert.AreEqual("Fridge", data.MostExpensive.Name);
        }

        [Test]
        public void AscendingOrderMostExpensiveAndLeastExpensiveProducts()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Set of Dishes", 70.00), 1);
            cart.Add(new Product("Blender", 250.00), 1);
            cart.Add(new Product("Fridge", 450.00), 1);

            var data = cart.GetMostExpensiveAndLeastExpensiveProducts();
            Assert.AreEqual("Set of Dishes", data.LeastExpensive.Name);
            Assert.AreEqual("Fridge", data.MostExpensive.Name);
        }

        [Test]
        public void VariedOrderMostExpensiveAndLeastExpensiveProducts()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Blender", 250.00), 1);
            cart.Add(new Product("Set of Dishes", 70.00), 1);
            cart.Add(new Product("Fridge", 450.00), 1);

            var data = cart.GetMostExpensiveAndLeastExpensiveProducts();
            Assert.AreEqual("Set of Dishes", data.LeastExpensive.Name);
            Assert.AreEqual("Fridge", data.MostExpensive.Name);
        }

        [Test]
        public void OneProductMostExpensiveAndLeastExpensiveProducts()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Blender", 250.00), 1);

            var data = cart.GetMostExpensiveAndLeastExpensiveProducts();
            Assert.AreEqual("Blender", data.LeastExpensive.Name);
            Assert.AreEqual("Blender", data.MostExpensive.Name);
        }

        [Test]
        public void NoProducstMostExpensiveAndLeastExpensiveProducts()
        {
            var cart = new ShoppingCart();

            var data = cart.GetMostExpensiveAndLeastExpensiveProducts();
            Assert.AreEqual(null, data.LeastExpensive);
            Assert.AreEqual(null, data.MostExpensive);
        }

        [Test]
        public void NoProductsHighestItemValue()
        {
            var cart = new ShoppingCart();

            var value = cart.GetHighestItemValue();
            Assert.AreEqual(0.00, value, 0.00001);
        }

        [Test]
        public void OneProductHighestItemValue()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Blender", 250.00), 1);

            var value = cart.GetHighestItemValue();
            Assert.AreEqual(250 * 1, value);
        }

        [Test]
        public void MultipleProductsHighestItemValue()
        {
            var cart = new ShoppingCart();
            cart.Add(new Product("Blender", 250.00), 2);
            cart.Add(new Product("Fridge", 450.00), 1);
            cart.Add(new Product("Set of Dishes", 70.00), 8);

            var value = cart.GetHighestItemValue();
            Assert.AreEqual(70 * 8, value);
        }
    }
}
