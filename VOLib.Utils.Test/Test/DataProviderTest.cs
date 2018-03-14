using System.Linq;
using NUnit.Framework;

namespace VOLib.Utils.Test.Test
{
    [TestFixture]
    [Order(10)]
    public class DataProviderTest : BaseTest
    {
        [Test]
        public void GimmeEnumerableWithTestItemCountFromFive()
        {
            Assert.AreEqual(5, DataProvider.GimmeEnumerableWith(5).GimmeSomeData().Count());
        }

        [Test]
        public void GimmeEnumerableWithTestItemCountFromOne()
        {
            Assert.AreEqual(1, DataProvider.GimmeEnumerableWith(1).GimmeSomeData().Count());
        }

        [Test]
        public void GimmeEnumerableWithTestItemCountFromZero()
        {
            Assert.AreEqual(0, DataProvider.GimmeEnumerableWith(0).GimmeSomeData().Count());
        }
    }
}