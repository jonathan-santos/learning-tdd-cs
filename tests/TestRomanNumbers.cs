using NUnit.Framework;

namespace RomanNumbers
{
    public class TestRomanNumbers
    {
        [Test]
        public void MustConvertNumberI()
        {
            var number = RomanNumberConverter.Convert("I");
            Assert.AreEqual(1, number);
        }

        [Test]
        public void MustConvertNumberV()
        {
            var number = RomanNumberConverter.Convert("V");
            Assert.AreEqual(5, number);
        }

        [Test]
        public void MustConvertNumberX()
        {
            var number = RomanNumberConverter.Convert("X");
            Assert.AreEqual(10, number);
        }

        [Test]
        public void MustConvertNumberII()
        {
            var number = RomanNumberConverter.Convert("II");
            Assert.AreEqual(2, number);
        }

        [Test]
        public void MustConvertNumberXXVII()
        {
            var number = RomanNumberConverter.Convert("XXVII");
            Assert.AreEqual(27, number);
        }

        [Test]
        public void MustConvertNumberIX()
        {
            var number = RomanNumberConverter.Convert("IX");
            Assert.AreEqual(9, number);
        }

        [Test]
        public void MustConvertNumberCXXIX()
        {
            var number = RomanNumberConverter.Convert("CXXIX");
            Assert.AreEqual(129, number);
        }
    }
}
