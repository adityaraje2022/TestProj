using NUnit.Framework;
using UniTTest;

namespace TestProj
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
            int result = SerialPortParser.ParsePort("COM1");
            Assert.That(result, Is.EqualTo(1));
            //Assert.Pass();
        }
    }
}