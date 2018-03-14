using System.Linq;
using NUnit.Framework;
using VOLib.Utils.Extension.System;

namespace VOLib.Utils.Test.Extension.System
{
    [TestFixture]
    [Order(20)]
    public class EnumerableExtensionTest : BaseTest
    {
        [Test]
        public void PickRandomTestItemCountFromFive()
        {
            Assert.AreEqual(2, DataProvider.GimmeEnumerableWith(5).GimmeSomeData().PickRandom(2).Count());
        }

        [Test]
        public void PickRandomTestItemIsIntFromFiveWithEmptyArgument()
        {
            Assert.IsInstanceOf<int>(DataProvider.GimmeEnumerableWith(5).GimmeSomeData().PickRandom());
        }

        [Test]
        public void PickRandomTestItemCountFromOne()
        {
            Assert.AreEqual(1, DataProvider.GimmeEnumerableWith(1).GimmeSomeData().PickRandom(2).Count());
        }

        [Test]
        public void PickRandomTestItemCountFromZero()
        {
            Assert.AreEqual(0, DataProvider.GimmeEnumerableWith(0).GimmeSomeData().PickRandom(2).Count());
        }
    }
}