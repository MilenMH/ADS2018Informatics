using System;
using AlgorithmsAndDataStructures.Algorithms.Interfaces;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class SelectionSort<T> : SortingAlgorithm<T> where T : IComparable<T>
    {
        public T[] Sort(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var currentMinimum = array[i];
                var currentMinimumIndex = i;

                for (int j = i + 1; j < array.Length ; j++)
                {
                    if (array[j].CompareTo(array[i]) < 0)
                    {
                        currentMinimum = array[j];
                        currentMinimumIndex = j;
                    }
                }

                var temp = array[i];
                array[i] = array[currentMinimumIndex];
                array[currentMinimumIndex] = temp;
            }
            return array;
        }
    }
}
