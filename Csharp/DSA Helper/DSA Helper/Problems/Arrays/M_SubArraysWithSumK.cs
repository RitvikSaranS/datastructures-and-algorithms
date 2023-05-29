using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    // https://leetcode.com/problems/subarray-sum-equals-k
    class M_SubArraysWithSumK
    {
        int[] nums;
        public M_SubArraysWithSumK(int[] nums)
        {
            this.nums = nums;
        }
        public void SubarraysCount(int k)
        {
            var prefixSum = new Dictionary<int, int>();
            prefixSum.Add(0, 1);
            int count = 0;
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (prefixSum.ContainsKey(sum - k)) count += prefixSum[sum - k];
                if (prefixSum.ContainsKey(sum)) prefixSum[sum]++;
                else prefixSum.Add(sum, 1);
            }
            Console.WriteLine(count);
        }
    }
}
