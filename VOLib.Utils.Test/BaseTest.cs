using Ninject;
using NUnit.Framework;

namespace VOLib.Utils.Test
{
    [TestFixture]
    public abstract class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            using (var kernel = new StandardKernel())
            {
                kernel.Inject(this);
            }
        }

        [Inject]
        public DataProvider DataProvider { protected get; set; }
    }
}