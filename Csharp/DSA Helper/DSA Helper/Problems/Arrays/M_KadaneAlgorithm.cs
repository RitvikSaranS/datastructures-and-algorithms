using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    // https://leetcode.com/problems/maximum-subarray
    class M_KadaneAlgorithm
    {
        int[] nums;
        public M_KadaneAlgorithm(int[] nums)
        {
            this.nums = nums;
        }
        public void MaximumSubarraySum()
        {
            int maxSum = nums[0];
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if(sum > maxSum)
                {
                    maxSum = sum;
                }if(sum < 0)
                {
                    sum = 0;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
