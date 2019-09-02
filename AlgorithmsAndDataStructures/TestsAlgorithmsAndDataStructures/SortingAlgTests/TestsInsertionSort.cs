using AlgorithmsAndDataStructures.Algorithms.SortingAlg;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestsAlgorithmsAndDataStructures.SortingAlgTests
{
    [TestClass]
    public class TestsInsertionSort
    {
        [TestMethod]
        public void Sort_GeneralTest()
        {
            var bubleSort = new InsertionSort<int>();
            var array = new int[] { 1, -8, 12, 254, 44, -98, 5 };
            var expected = new int[] { -98, -8, 1, 5, 12, 44, 254 };

            var actual = bubleSort.Sort(array);

            Assert.IsTrue(expected.SequenceEqual(actual));

        }
    }
}
