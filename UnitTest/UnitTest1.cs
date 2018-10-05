using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandatoryAssignment;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new Converter();
            Assert.AreEqual(280, Converter.ToGram(100), 0.003);
        }
    }
}
