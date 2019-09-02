using AlgorithmsAndDataStructures.Algorithms.SortingAlg;
using C5;
using System;

namespace AlgorithmsAndDataStructures.Algorithms.KSmallestElements
{
    public class KSmallestElements
    {
        public int[] SortAndReturnKthSmallestElements(int[] array, int kSmallestValues)
        {
            var quickSprt = new QuickSort();
            quickSprt.Sort(array, 0, array.Length - 1);
            int[] result = new int[kSmallestValues];
            Array.Copy(array, 0, result, 0, kSmallestValues);
            return result;
        }

        /// <summary>
        /// Quickselect : Average performance O(n)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="kSmallestElement"></param>
        public int FindTheKthSmallestElementWithLinearTimeComplexity(int[] array, int kSmallestElement)
        {
            return KthSmallest(array, 0, array.Length - 1, kSmallestElement);
        }

        /// <summary>
        /// The Interval heap used in this method represents the min heap 
        /// required form the last sub task of task 7.37.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="kSmallestElement"></param>
        /// <returns></returns>
        public int FindKthSmallestElementUsingMinHeap(int[] array, int kSmallestElement)
        {
            var n = array.Length;

            if (n - 1 < kSmallestElement)
            {
                return int.MinValue;
            }

            IntervalHeap<int> intervalHeap = new IntervalHeap<int>();

            for (int i = 0; i < n; i++)
            {
                if (intervalHeap.Count < kSmallestElement)
                {
                    intervalHeap.Add(array[i]);
                }
                else
                {
                    if (intervalHeap.FindMax() > array[i])
                    {
                        intervalHeap.DeleteMax();
                        intervalHeap.Add(array[i]);
                    }
                }
            }
            for (int i = 0; i < kSmallestElement - 1; i++)
            {
                intervalHeap.DeleteMin();
            }
            return intervalHeap.FindMin();
        }


        #region private methods

        private int KthSmallest(int[] arr, int l, int r, int k)
        {
            if (k > 0 && k <= r - l + 1)
            {
                int pos = RandomPartition(arr, l, r);
                if (pos - l == k - 1)
                {
                    return arr[pos];
                }

                if (pos - l > k - 1)
                {
                    return KthSmallest(arr, l, pos - 1, k);
                }
                return KthSmallest(arr, pos + 1, r, k - pos + l - 1);
            }

            return int.MaxValue;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private int Partition(int[] arr, int l, int r)
        {
            int x = arr[r], i = l;
            for (int j = l; j <= r - 1; j++)
            {
                if (arr[j] <= x)
                {
                    this.Swap(arr, i, j);
                    i++;
                }
            }
            this.Swap(arr, i, r);
            return i;
        }

        private int RandomPartition(int[] array, int l, int r)
        {
            int n = r - l + 1;
            Random rnd = new Random();
            int rand = rnd.Next(0, 1);
            int pivot = (int)(rand * (n - 1));
            Swap(array, l + pivot, r);
            return Partition(array, l, r);
        }

        #endregion
    }
}
