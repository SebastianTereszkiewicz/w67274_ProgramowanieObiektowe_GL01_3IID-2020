using ClassLibrary1.Models;

namespace TestProject
{
    public class Tests
    {
        private Licz licz;
        [SetUp]
        public void Setup()
        {
            licz = new Licz();
        }

        [Test]
        public object ShouldCreateObject()
        {
            Assert.NotNull;
        }

        [Test]
        [TestCase(2,5,6)]
        public void Dodaj_Test()
        {
            Assert.Pass();
        }
    }

    internal class TestCaseAttribute : Attribute
    {
    }

    internal class TestAttribute : Attribute
    {
    }

    internal class SetUpAttribute : Attribute
    {
    }
}