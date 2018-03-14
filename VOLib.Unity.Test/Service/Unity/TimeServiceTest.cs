using NUnit.Framework;
using VOLib.Unity.Service.Unity;
using Zenject;

namespace VOLib.Unity.Test.Service.Unity
{
    public class TimeServiceTest
    {

        public DiContainer Container { get; set; }

        [SetUp]
        public void SetUp()
        {
            Container = new DiContainer();
            Container.Bind<ITimeService>().FromMock().AsSingle();
            Container.Inject(this);
        }

        [Inject]
        public ITimeService TimeService { get; set; }

        [Test]
        public void DeltaTimeReturnsPositiveValue()
        {
            Assert.Positive(TimeService.deltaTime);
        }
    }
}
