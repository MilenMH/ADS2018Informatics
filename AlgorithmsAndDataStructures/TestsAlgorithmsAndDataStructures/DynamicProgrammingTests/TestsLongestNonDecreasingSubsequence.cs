using AlgorithmsAndDataStructures.Algorithms.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestsAlgorithmsAndDataStructures.DynamicProgrammingTests
{
    [TestClass]
    public class TestsLongestNonDecreasingSubsequence
    {
        [TestMethod]
        public void GetSubsequence_GeneralTest()
        {
            int[] nums = new int[] { 3, 14, 5, 5, 12, 15, 7, 8, 9, 11, 10, 1 };
            var longestNonDecreasingSubsequence = new LongestNonDecreasingSubsequence();
            var expected = new int[] { 3, 5, 5, 7, 8, 9, 11 };

            var actual = longestNonDecreasingSubsequence.GetSubsequence(nums);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void GetSubsequence_GivenEmptyArray_ShouldReturnEmptyArray()
        {
            int[] nums = new int[] {  };
            var longestNonDecreasingSubsequence = new LongestNonDecreasingSubsequence();
            var expected = new int[] { };

            var actual = longestNonDecreasingSubsequence.GetSubsequence(nums);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void GetSubsequence_GeneralTest2()
        {
            int[] nums = new int[] {1, 2, 3, 4, 5, -8, -7, -6, -5, -4, -3, 9 };
            var longestNonDecreasingSubsequence = new LongestNonDecreasingSubsequence();
            var expected = new int[] { -8, -7, -6, -5, -4, -3, 9 };

            var actual = longestNonDecreasingSubsequence.GetSubsequence(nums);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
