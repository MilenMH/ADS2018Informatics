using System;
using AlgorithmsAndDataStructures.Algorithms.Interfaces;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class InsertionSort<T> : SortingAlgorithm<T> where T : IComparable<T>
    {
        public T[] Sort(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1].CompareTo(array[j]) > 0)
                    {
                        var temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
