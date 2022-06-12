using Microsoft.VisualStudio.TestTools.UnitTesting;
using day6;
using Shouldly;

namespace day6calTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            var calc = new Cal();
            double actual = calc.Add(4.0, 5.0);
            //Assert.AreEqual(9, actual);
            actual.ShouldBe(9);
        }
        [TestMethod]
        public void SubstractTest()
        {
            double actual = Cal.Substract(9, 5);
            //Assert.AreEqual(4, actual);
            actual.ShouldBe(4);

        }
    }
}
