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
            Assert.IsNotEmpty(Program.Prefix("Hello"));
        }
        [Test]
        public void Test2()
        {
            Assert.IsNotEmpty(Program.Prefix("0:0"));
        }
        [Test]
        public void Test3()
        {
            Assert.IsNotEmpty(Program.Prefix("what  ... did you say??"));
        }
    }
}