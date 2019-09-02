using System;

namespace AlgorithmsAndDataStructures.Algorithms.SortingAlg
{
    public class SelectionSort<T> where T : IComparable<T>
    {
        public T[] Sort(T[] arr)
        {
            T temp; 
            int smallest;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
    }
}
