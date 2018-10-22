using System;

namespace AlgorithmsAndDataStructures.Algorithms.Interfaces
{
    public interface SortingAlgorithm<T> where T : IComparable<T>
    {
        T[] Sort(T[] array);
    }
}
