using AlgorithmsAndDataStructures.Algorithms.BinaryConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestsAlgorithmsAndDataStructures.BinaryConversionTests
{
    [TestClass]
    public class TestsBinaryConverter
    {

        [TestMethod]
        public void ToDecimal_ConvertBinaryZeroToDecimalZero()
        {
            var binaryConverter = new BinaryConverter();
            var expected = "0";

            var actual = binaryConverter.ToDecimal(expected);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToDecimal_ConvertComplexNumbers()
        {
            var binaryConverter = new BinaryConverter();
            var expected = "247";

            var actual = binaryConverter.ToDecimal("11110111");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToDecimal_ConvertComplexNumbers2()
        {
            var binaryConverter = new BinaryConverter();
            var expected = "584";

            var actual = binaryConverter.ToDecimal("1001001000");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToBinary_ConvertDecimalZeroToBinaryZero()
        {
            var binaryConverter = new BinaryConverter();
            var expected = "0";

            var actual = binaryConverter.ToBinary("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToBinary_ConvertComplexNumbers()
        {
            var binaryConverter = new BinaryConverter();
            var expected = "1001001000";

            var actual = binaryConverter.ToBinary("584");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToBinary_ConvertComplexNumbers2()
        {
            var binaryConverter = new BinaryConverter();
            var expected = "11110111";

            var actual = binaryConverter.ToBinary("247");

            Assert.AreEqual(expected, actual);
        }
    }
}
