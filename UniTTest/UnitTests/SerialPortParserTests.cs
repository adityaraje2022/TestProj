using UniTTest;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class SerialPortParserTests
    {
        [Test]
        public void ParsePortCOM1Returns1()
        {
            int result = SerialPortParser.ParsePort("COM1");
            Assert.That(result, Is.EqualTo(1));

        }
    }
}