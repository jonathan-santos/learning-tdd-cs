using NUnit.Framework;

namespace ShoppingCartAnalyzer
{
    public class TestShoppingCartAnalyzer
    {
        ShoppingCart cart;

        [SetUp]
        public void Initialize()
        {
            this.cart = new ShoppingCart();
        }

        [Test]
        public void DecreasingOrderMostExpensiveAndLeastExpensiveProducts()
        {
            cart = new ShoppingCartBuilder()
                .WithItens(new [] {
                    ("Fridge", 450.00),
                    ("Blender", 250.00),
                    ("Set of Dishes", 70.00)
                }).Build();

            var data = cart.GetMostExpensiveAndLeastExpensiveProducts();
            Assert.AreEqual("Set of Dishes", data.LeastExpensive.Name);
            Assert.AreEqual("Fridge", data.MostExpensive.Name);
        }

        [Test]
        public void AscendingOrderMostExpensiveAndLeastExpensiveProducts()
        {
            cart = new ShoppingCartBuilder()
                .WithItens(new [] {
                    ("Set of Dishes", 70.00),
                    ("Blender", 250.00),
                    ("Fridge", 450.00)
                }).Build();

            var data = cart.GetMostExpensiveAndLeastExpensiveProducts();
            Assert.AreEqual("Set of Dishes", data.LeastExpensive.Name);
            Assert.AreEqual("Fridge", data.MostExpensive.Name);
        }

        [Test]
        public void VariedOrderMostExpensiveAndLeastExpensiveProducts()
        {
            cart = new ShoppingCartBuilder()
                .WithItens(new [] {
                    ("Blender", 250.00),
                    ("Set of Dishes", 70.00),
                    ("Fridge", 450.00)
                }).Build();

            var data = cart.GetMostExpensiveAndLeastExpensiveProducts();
            Assert.AreEqual("Set of Dishes", data.LeastExpensive.Name);
            Assert.AreEqual("Fridge", data.MostExpensive.Name);
        }

        [Test]
        public void OneProductMostExpensiveAndLeastExpensiveProducts()
        {
            cart = new ShoppingCartBuilder()
                .WithItens(new [] {
                    ("Blender", 250.00)
                }).Build();

            var data = cart.GetMostExpensiveAndLeastExpensiveProducts();
            Assert.AreEqual("Blender", data.LeastExpensive.Name);
            Assert.AreEqual("Blender", data.MostExpensive.Name);
        }

        [Test]
        public void NoProducstMostExpensiveAndLeastExpensiveProducts()
        {
            var data = cart.GetMostExpensiveAndLeastExpensiveProducts();
            Assert.AreEqual(null, data.LeastExpensive);
            Assert.AreEqual(null, data.MostExpensive);
        }

        [Test]
        public void NoProductsHighestItemValue()
        {
            var value = cart.GetHighestItemValue();
            Assert.AreEqual(0.00, value, 0.00001);
        }

        [Test]
        public void OneProductHighestItemValue()
        {
            cart = new ShoppingCartBuilder()
                .WithItens(new [] {
                    ( 250.00, 1 ),
                }).Build();

            var value = cart.GetHighestItemValue();
            Assert.AreEqual(250 * 1, value);
        }

        [Test]
        public void MultipleProductsHighestItemValue()
        {
            cart = new ShoppingCartBuilder()
                .WithItens(new [] {
                    ( 250.00, 2 ),
                    ( 450.00, 1 ),
                    ( 70.00, 8 )
                }).Build();

            var value = cart.GetHighestItemValue();
            Assert.AreEqual(70 * 8, value);
        }
    }

    public class ShoppingCartBuilder
    {
        public ShoppingCart cart;

        public ShoppingCartBuilder()
        {
            this.cart = new ShoppingCart();
        }

        public ShoppingCartBuilder WithItens((double price, int quantity)[] items)
        {
            foreach (var item in items)
                cart.Add(new Product("Item", item.price), item.quantity);

            return this;
        }

        public ShoppingCartBuilder WithItens((string name, double price)[] items)
        {
            foreach (var item in items)
                cart.Add(new Product(item.name, item.price), 1);

            return this;
        }

        public ShoppingCart Build()
        {
            return cart;
        }
    }
}
