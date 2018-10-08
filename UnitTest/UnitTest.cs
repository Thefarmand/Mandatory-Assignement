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
            Assert.AreEqual(28.34952, Converter.ToGram(1), 0.001);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Test for afvigelse på 0.001 gram skal blive grøn        
            Assert.AreEqual(0.03527396195, Converter.ToOunce(1), 0.001);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Test for negativt tal. Skal blive grøn
            Assert.AreEqual(-28.34952, Converter.ToGram(-1), 0.001);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Test for negativt tal. Skal blive grøn
            Assert.AreEqual(-0.03527396195, Converter.ToOunce(-1), 0.001);
        }
    }
}
