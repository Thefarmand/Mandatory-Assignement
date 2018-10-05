using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandatoryAssignment;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Test for afvigelse på 0.001 gram skal blive grøn
            var test1 = new Converter();
            Assert.AreEqual(28.34952, Converter.ToGram(1), 0.001);
        }
        //Virker ikke endnu
        [TestMethod]
        public void TestMethod2()
        {
            //Test for afvigelse over 0.003 gram. Skal fejle
            var test2 = new Converter();
            Assert.AreEqual(28.34952, Converter.ToGram(1), 0.6);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Test for afvigelse over ounce. Skal fejle
            var test3 = new Converter();
            Assert.AreEqual(0.3527, Converter.ToOunce(1), 0.001);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Test for afvigelse over ounce. Skal fejle
            var test4 = new Converter();
            Assert.AreEqual(0.35279, Converter.ToOunce(1), 0.015);
        }
    }
}
