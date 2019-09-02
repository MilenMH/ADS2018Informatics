using AlgorithmsAndDataStructures.Algorithms.MaximumCombinationOfActivities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestsAlgorithmsAndDataStructures.MaximumCombinationsOfActivities
{
    [TestClass]
    public class TestsMaximumCombinationsOfActivities
    {

        [TestMethod]
        public void BruteForceSolution_EmptyListOfLectures_ShouldRetornEmptyListOfLecture()
        {

            var maximumCombinationsOfActivities = new AlgorithmsAndDataStructures.Algorithms.MaximumCombinationOfActivities.MaximumCombinationsOfActivities();
            var listOfLectures = new List<Lecture>();
            var expected = new List<Lecture>();

            var actual = maximumCombinationsOfActivities.BruteForceSolution(listOfLectures);


            Assert.IsTrue(expected.SequenceEqual(actual));
        }


        [TestMethod]
        public void BruteForceSolution_GeneralComplexTest()
        {
            var maximumCombinationsOfActivities = new AlgorithmsAndDataStructures.Algorithms.MaximumCombinationOfActivities.MaximumCombinationsOfActivities();
            var listOfLectures = new List<Lecture>() {
                new Lecture(new DateTime(2019, 08, 30, 8, 0, 0), new DateTime(2019, 08, 30, 10, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 9, 0, 0), new DateTime(2019, 08, 30, 11, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 10, 0, 0), new DateTime(2019, 08, 30, 17, 0, 0), true),
                new Lecture(new DateTime(2019, 08, 30, 11, 0, 0), new DateTime(2019, 08, 30, 13, 0, 0), true),
                new Lecture(new DateTime(2019, 08, 30, 13, 0, 0), new DateTime(2019, 08, 30, 15, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 18, 0, 0), new DateTime(2019, 08, 30, 19, 0, 0), false),
            };
            var expected = new List<Lecture>() {
                new Lecture(new DateTime(2019, 08, 30, 8, 0, 0), new DateTime(2019, 08, 30, 10, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 10, 0, 0), new DateTime(2019, 08, 30, 17, 0, 0), true),
                new Lecture(new DateTime(2019, 08, 30, 18, 0, 0), new DateTime(2019, 08, 30, 19, 0, 0), false),
            };

            var actual =  maximumCombinationsOfActivities.BruteForceSolution(listOfLectures);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }


        [TestMethod]
        public void BruteForceSolution_GeneralComplexTest2()
        {

            var maximumCombinationsOfActivities = new AlgorithmsAndDataStructures.Algorithms.MaximumCombinationOfActivities.MaximumCombinationsOfActivities();
            var listOfLectures = new List<Lecture>() {
                new Lecture(new DateTime(2019, 08, 30, 9, 0, 0), new DateTime(2019, 08, 30, 11, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 11, 0, 0), new DateTime(2019, 08, 30, 12, 0, 0), true),
                new Lecture(new DateTime(2019, 08, 30, 10, 0, 0), new DateTime(2019, 08, 30, 11, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 9, 0, 0), new DateTime(2019, 08, 30, 10, 0, 0), true),
                new Lecture(new DateTime(2019, 08, 30, 8, 0, 0), new DateTime(2019, 08, 30, 9, 0, 0), false),
            };
            var expected = new List<Lecture>() {
                new Lecture(new DateTime(2019, 08, 30, 8, 0, 0), new DateTime(2019, 08, 30, 9, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 9, 0, 0), new DateTime(2019, 08, 30, 10, 0, 0), true),
                new Lecture(new DateTime(2019, 08, 30, 10, 0, 0), new DateTime(2019, 08, 30, 11, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 11, 0, 0), new DateTime(2019, 08, 30, 12, 0, 0), true),
            };

            var actual = maximumCombinationsOfActivities.BruteForceSolution(listOfLectures);


            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void BruteForceSolution_GeneralComplexTest3()
        {

            var maximumCombinationsOfActivities = new AlgorithmsAndDataStructures.Algorithms.MaximumCombinationOfActivities.MaximumCombinationsOfActivities();
            var listOfLectures = new List<Lecture>() {
                new Lecture(new DateTime(2019, 08, 30, 10, 0, 0), new DateTime(2019, 08, 30, 14, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 10, 0, 0), new DateTime(2019, 08, 30, 11, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 11, 0, 0), new DateTime(2019, 08, 30, 13, 0, 0), true),
                new Lecture(new DateTime(2019, 08, 30, 13, 0, 0), new DateTime(2019, 08, 30, 14, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 14, 0, 0), new DateTime(2019, 08, 30, 20, 0, 0), true),
            };
            var expected = new List<Lecture>() {
                new Lecture(new DateTime(2019, 08, 30, 10, 0, 0), new DateTime(2019, 08, 30, 14, 0, 0), false),
                new Lecture(new DateTime(2019, 08, 30, 14, 0, 0), new DateTime(2019, 08, 30, 20, 0, 0), true),
            };

            var actual = maximumCombinationsOfActivities.BruteForceSolution(listOfLectures);


            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
