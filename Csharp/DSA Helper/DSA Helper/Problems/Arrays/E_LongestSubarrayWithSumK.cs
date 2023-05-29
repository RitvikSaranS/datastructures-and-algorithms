using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    class E_LongestSubarrayWithSumK
    {
        int[] nums;
        public E_LongestSubarrayWithSumK(int[] nums)
        {
            this.nums = nums;
        }
        public void LongestSubarray(int target)
        {
            if (nums.Length == 0) return;
            int i = 0;
            int j = 0;
            int sum = nums[0];
            int[] arr = new int[] { -1, -1 };
            while(i < nums.Length && j < nums.Length)
            {
                if(i != j) sum += nums[j];
                while(sum >= target)
                {
                    if (sum == target)
                    {
                        if (arr[1] - arr[0] <= j - i)
                        {
                            arr[0] = i;
                            arr[1] = j;
                        }
                    }
                    sum -= nums[i++];
                }
                j++;
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + " ");
            }
        }
        public void LongestSubarray2(int target)
        {
            var prefixSum = new Dictionary<int, int>();
            prefixSum.Add(0, 0);
            int sum = 0;
            int maxLength = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (prefixSum.ContainsKey(sum - target)) maxLength = Math.Max(maxLength, i - prefixSum[sum - target]);
                if (sum == target) maxLength = Math.Max(maxLength, i + 1);
                if (!prefixSum.ContainsKey(sum)) prefixSum.Add(sum, i);
            }
            Console.WriteLine(maxLength);
        }
    }
}
