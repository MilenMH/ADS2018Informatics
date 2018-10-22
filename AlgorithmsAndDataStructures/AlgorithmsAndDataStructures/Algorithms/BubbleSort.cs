using System;
using AlgorithmsAndDataStructures.Algorithms.Interfaces;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class BubbleSort<T> : SortingAlgorithm<T> where T : IComparable<T>
    {
        public T[] Sort(T[] array)
        {
            var swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        swapped = true;
                    }
                }
            } while (swapped);

            return array;
        }
    }
}
