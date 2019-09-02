using AlgorithmsAndDataStructures.Algorithms.RadiusOfReachability;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestsAlgorithmsAndDataStructures.RadiusOfReachabilityTests
{
    [TestClass]
    public class TestsRadiusOfReachability
    {

        [TestMethod]
        public void SolveByBinarySearch_GeneralTest()
        {
            var radiusOfReachability = new RadiusOfReachability();
            var expected = new int[] { -5, -2, -1, 0, 1 };

            var actual = radiusOfReachability.SolveByBinarySearch(new int[] { -5, -2, -1, 0, 1, 2, 5 }, -3, 4);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void SolveByBinarySearch_ForZeroRadius_ShouldReturnTheExactKeyPoint()
        {
            var radiusOfReachability = new RadiusOfReachability();
            var expected = new int[] { 0 };

            var actual = radiusOfReachability.SolveByBinarySearch(new int[] { -5, -2, -1, 0, 1, 2, 5 }, 0, 0);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void SolveByBinarySearch_ForRadiusReachingEveryPossibleValue_ShouldReturnThePassedArray()
        {
            var radiusOfReachability = new RadiusOfReachability();
            var expected = new int[] { -5, -2, -1, 0, 1, 2, 5 };

            var actual = radiusOfReachability.SolveByBinarySearch(new int[] { -5, -2, -1, 0, 1, 2, 5 }, 0, 50);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void SolveByBinarySearch_ForKeyOneAndRaiusOne_ShouldReturnMinusOneZeroAndOne()
        {
            var radiusOfReachability = new RadiusOfReachability();
            var expected = new int[] { -1, 0, 1 };

            var actual = radiusOfReachability.SolveByBinarySearch(new int[] { -5, -2, -1, 0, 1, 2, 5 }, 0, 1);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
