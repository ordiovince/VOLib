using Moq;

// ReSharper disable CheckNamespace
namespace Zenject
{
    public static class ZenjectMoqExtensions
    {
        public static ScopeConditionCopyNonLazyBinder FromMock<TContract>(this FromBinderGeneric<TContract> binder)
            where TContract : class
        {
            return binder.FromInstance(Mock.Of<TContract>());
        }

        public static ConditionCopyNonLazyBinder FromMock<TContract>(this FactoryToChoiceIdBinder<TContract> binder)
            where TContract : class
        {
            return binder.FromInstance(Mock.Of<TContract>());
        }

        public static ConditionCopyNonLazyBinder FromMock<TContract>(this MemoryPoolInitialSizeBinder<TContract> binder)
            where TContract : class
        {
            return binder.FromInstance(Mock.Of<TContract>());
        }
    }
}
