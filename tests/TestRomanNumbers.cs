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
    }
}
