using Lab2.Models;

namespace NUnitTestProject1
{
    public class LiczTest
    {
        private Licz licz;

        [SetUp]
        public void Setup()
        {
            licz = new Licz(5);
        }

        [Test]
        public void ShouldCreateObject()
        {
            Assert.NotNull(licz);
        }


        [Test]
        [TestCase(2, 5, -3)]
        [TestCase(5, 6, -1)]
        public void Dodaj_Test(int i, int x, int expect)
        {
            licz.Dodaj(i);
            licz.Dodaj(x);
            Assert.AreEqual(expect, licz.Value);
        }

        public void Oddejmij_Test(int i, int x, int expect)
        {
            licz.Oddejmnij(i);
            licz.Oddejmnij(x);
            Assert.AreEqual(expect, licz.Value);
        }
    }
}