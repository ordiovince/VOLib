using System.Collections.Generic;
using Moq;

namespace VOLib.Utils.Test
{
    public partial class DataProvider
    {
        public IGenericInterface<IEnumerable<int>> GimmeEnumerableWith(int nbItems)
        {
            var list = new List<int>();

            for (var i = 0; i < nbItems; i++) list.Add(i);

            IEnumerable<int> enumerable = list.ToArray();

            // ReSharper disable once PossibleUnintendedReferenceComparison
            return Mock.Of<IGenericInterface<IEnumerable<int>>>(genericInterface => genericInterface.GimmeSomeData() == enumerable);
        }
    }
}