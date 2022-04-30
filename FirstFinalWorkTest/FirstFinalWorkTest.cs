using NUnit.Framework;

namespace FirstFinalWorkTest
{
    public class FirstFinalWorkTests
    {
        [Test]
        public void Get3CharsStrinArrayTest01()
        {
            string[] expectedResult = new string[] {"2", ":-)"};

            Assert.AreEqual(expectedResult,
                FirstFinalWork.Get3CharsStrinArray(new[] { "Hello", "2", "world", ":-)" }));
        }
        [Test]
        public void Get3CharsStrinArrayTest02()
        {
            string[] expectedResult = new string[] {"-2"};

            Assert.AreEqual(expectedResult,
                FirstFinalWork.Get3CharsStrinArray(new[] { "1234", "1567", "-2", "computer science" }));
        }
        [Test]
        public void Get3CharsStrinArrayTest03()
        {
            string[] expectedResult = new string[] {};

            Assert.AreEqual(expectedResult,
                FirstFinalWork.Get3CharsStrinArray(new[] { "Russia", "Denmark", "Kazan" }));
        }
        [Test]
        public void Get3CharsStrinArrayTest04()
        {
            string[] expectedResult = new string[] {};

            Assert.AreEqual(expectedResult,
                FirstFinalWork.Get3CharsStrinArray(new string[] { }));
        }
        public void Get3CharsStrinArrayTest05()
        {
            string[] expectedResult = new string[] {};

            Assert.AreEqual(expectedResult,
                FirstFinalWork.Get3CharsStrinArray(null));
        }
    }
}