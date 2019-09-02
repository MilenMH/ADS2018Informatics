using AlgorithmsAndDataStructures.Algorithms.SortingAlg;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestsAlgorithmsAndDataStructures.SortingAlgTests
{
    [TestClass]
    public class TestsBubbleSort
    {
        [TestMethod]
        public void Sort_GeneralTest()
        {
            var bubleSort = new BubbleSort<int>();
            var array = new int[] { 1, -8, 12, 254, 44, -98, 5};
            var expected = new int[] {-98, -8, 1, 5, 12,44, 254 };

            var actual = bubleSort.Sort(array);

            Assert.IsTrue(expected.SequenceEqual(actual));

        }
    }
}
