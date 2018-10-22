using System;
using AlgorithmsAndDataStructures.Algorithms;
using AlgorithmsAndDataStructures.Algorithms.Interfaces;

namespace AlgorithmsAndDataStructures
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            var array = new int[] { 1, 4, 2, 77, -7, 0 };
            SortingAlgorithm<int> sorter = new BubbleSort<int>();
            var sorted = sorter.Sort(array);

            Console.WriteLine(string.Join(",", sorted));

            array = new int[] { 15, 12, 7, 1, 0, -99 };
            sorter = new SelectionSort<int>();
            sorted = sorter.Sort(array);

            Console.WriteLine(string.Join(",", sorted));

            array = new int[] { 15, 12, 7, 1, 0, -99 };
            sorter = new InsertionSort<int>();
            sorted = sorter.Sort(array);

            Console.WriteLine(string.Join(",", sorted));
        }
    }
}
