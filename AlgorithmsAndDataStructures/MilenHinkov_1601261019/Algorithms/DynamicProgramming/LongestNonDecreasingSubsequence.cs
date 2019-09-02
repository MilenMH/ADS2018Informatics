using System;

namespace AlgorithmsAndDataStructures.Algorithms.DynamicProgramming
{
    public class LongestNonDecreasingSubsequence
    {
        public int[] GetSubsequence(int[] nums)
        {
            int maxLength = 0;
            int lastIndex = -1;
            int[] len = new int[nums.Length];
            int[] prev = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int k = 0; k < i; k++)
                {
                    if (nums[k] <= nums[i] && len[k] + 1 > len[i])
                    {
                        len[i] = len[k] + 1;
                        prev[i] = k;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }

            int[] lis = new int[maxLength];
            int currentIndex = maxLength - 1;

            while (lastIndex != -1)
            {
                lis[currentIndex] = nums[lastIndex];
                currentIndex--;
                lastIndex = prev[lastIndex];
            }

            return lis;
        }
    }
}
