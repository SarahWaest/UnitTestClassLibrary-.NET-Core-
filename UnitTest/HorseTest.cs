using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class HorseTest
    { 
        private Horse _horse;

        [TestInitialize]
        public void Initialize()
        {
            _horse = new Horse();
        }

        [TestMethod]
        public void TestLegs()
        {
            Assert.AreEqual(4, _horse.legs);
        }

    }

    internal class Horse
    {
        public int legs;
    }
}