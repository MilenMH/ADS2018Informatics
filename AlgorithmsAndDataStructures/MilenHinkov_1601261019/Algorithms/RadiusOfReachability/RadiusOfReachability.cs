using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAndDataStructures.Algorithms.RadiusOfReachability
{
    public class RadiusOfReachability
    {
        public int[] SolveByBinarySearch(int[] array, int key, int radius)
        {
            var maxBoundary = radius + key;
            var minBoundary = key - radius;

            var low = 0;
            var high = (array.Length - 1);
            int? index = null;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                if (array[mid] > maxBoundary)
                {
                    high = mid - 1;
                }
                else if (array[mid] < minBoundary)
                {
                    low = mid + 1;
                }
                else
                {
                    index = mid;
                    break;
                }
            }

            low =  index.Value;
            high = index.Value;
            if (index.HasValue)
            {
                for (int i = index.Value; i < array.Length && array[i] <= maxBoundary; i++)
                {
                    high = i;
                }
                for (int i = index.Value; i >-1 && array[i] >= minBoundary; i--)
                {
                    low = i;
                }

                return array.Skip(low).Take(high - low + 1).ToArray();
            }
            return new int[0];
        }
    }
}
