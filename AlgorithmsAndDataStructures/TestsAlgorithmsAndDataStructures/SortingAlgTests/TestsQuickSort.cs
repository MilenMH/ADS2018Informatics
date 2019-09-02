using AlgorithmsAndDataStructures.Algorithms.SortingAlg;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestsAlgorithmsAndDataStructures.SortingAlgTests
{
    [TestClass]
    public class TestsQuickSort
    {

        [TestMethod]
        public void Sort_GeneralTest()
        {
            var bubleSort = new QuickSort();
            var actual = new int[] { 1, -8, 12, 254, 44, -98, 5 };
            var expected = new int[] { -98, -8, 1, 5, 12, 44, 254 };

            bubleSort.Sort(actual, 0, actual.Length - 1);

            Assert.IsTrue(expected.SequenceEqual(actual));

        }
    }
}
