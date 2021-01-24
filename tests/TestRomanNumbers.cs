using NUnit.Framework;

namespace RomanNumbers
{
    public class TestRomanNumbers
    {
        [Test]
        public void NumberI()
        {
            var number = RomanNumberConverter.Convert("I");
            Assert.AreEqual(1, number);
        }

        [Test]
        public void NumberV()
        {
            var number = RomanNumberConverter.Convert("V");
            Assert.AreEqual(5, number);
        }

        [Test]
        public void NumberX()
        {
            var number = RomanNumberConverter.Convert("X");
            Assert.AreEqual(10, number);
        }

        [Test]
        public void NumberII()
        {
            var number = RomanNumberConverter.Convert("II");
            Assert.AreEqual(2, number);
        }

        [Test]
        public void NumberXXVII()
        {
            var number = RomanNumberConverter.Convert("XXVII");
            Assert.AreEqual(27, number);
        }

        [Test]
        public void NumberIX()
        {
            var number = RomanNumberConverter.Convert("IX");
            Assert.AreEqual(9, number);
        }

        [Test]
        public void NumberCXXIX()
        {
            var number = RomanNumberConverter.Convert("CXXIX");
            Assert.AreEqual(129, number);
        }
    }
}
