using JetBrains.Annotations;
using Moq;
using Ninject.Syntax;

namespace VOLib.Utils.Extension.Ninject
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public static class MoqExtensions
    {
        public static IBindingWhenInNamedWithOrOnSyntax<TContract> FromMock<TContract>(this IBindingToSyntax<TContract> binder)
            where TContract : class
        {
            return binder.ToConstant(Mock.Of<TContract>());
        }
    }
}