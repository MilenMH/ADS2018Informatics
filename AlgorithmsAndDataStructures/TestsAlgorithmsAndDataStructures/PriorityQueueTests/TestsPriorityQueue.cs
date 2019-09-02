using AlgorithmsAndDataStructures.Algorithms.PriorityQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsAlgorithmsAndDataStructures.PriorityQueueTests
{
    [TestClass]
    public class TestsPriorityQueue
    {

        [TestMethod]
        public void PriorityQueue_GeneralTest()
        {
            var priorityQueue = new PriorityQueue<string>();
            priorityQueue.Add("georgi's group", "georgi");
            priorityQueue.Add("pesho's group", "pesho");
            priorityQueue.Add("pesho's group", "petko");
            priorityQueue.Add("milen's group", "milen");
            priorityQueue.Add("georgi's group", "joro");
            priorityQueue.Add("pesho's group", "petio");

            Assert.AreEqual("georgi", priorityQueue.Poll());
            Assert.AreEqual("joro", priorityQueue.Poll());
            Assert.AreEqual("pesho", priorityQueue.Poll());
            Assert.AreEqual("petko", priorityQueue.Poll());
            Assert.AreEqual("petio", priorityQueue.Poll());
            Assert.AreEqual("milen", priorityQueue.Poll());
        }
    }
}
