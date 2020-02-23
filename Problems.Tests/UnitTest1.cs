using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program p = new Program();
            string test = p.Prefix("hello");
            Assert.AreEqual(test, "5,1:hello");
        }

        [Test]
        public void Test2()
        {
            Program p = new Program();
            string test = p.Prefix("");
            Assert.AreEqual(test, "0,0:");
        }

        [Test]
        public void Test3()
        {
            Program p = new Program();
            string test = p.Prefix("what ... did you say??");
            Assert.AreEqual(test, "22,5:what ... did you say??");
        }
    }
}