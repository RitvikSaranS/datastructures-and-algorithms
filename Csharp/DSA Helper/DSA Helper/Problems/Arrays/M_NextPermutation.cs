using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    // [1, 2, 3, 4, 5, 6] => sample array
    // question : [1, 6, 5, 4, 3, 2] => ans : [2, 1, 3, 4, 5, 6]

    // Thought process
    // First we found 1(breaking point(nums[i] < nums[i + 1])) 
    // Found 2 (next greater to breaking point)
    // Swap both
    // reverse everything after breaking point

    // Problem Link
    // https://leetcode.com/problems/next-permutation/
    class M_NextPermutation
    {
        int[] nums;
        public M_NextPermutation(int[] nums)
        {
            this.nums = nums;
        }
        public void NextPermutation()
        {
            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1]) i--;
            if (i >= 0)
            {
                int nextBig = nums.Length - 1;
                while (nums[nextBig] < nums[i])
                {
                    nextBig--;
                }
                swap(nums, i, nextBig);
            }
            reverse(nums, i + 1, nums.Length - 1);
            for (int k = 0; k < nums.Length; k++)
            {
                Console.Write(nums[k] + " ");
            }
        }
        public void swap(int[] nums, int a, int b)
        {
            if (a > nums.Length || b < 0) return;
            int tmp = nums[a];
            nums[a] = nums[b];
            nums[b] = tmp;
        }
        public void reverse(int[] nums, int start, int end)
        {
            for (int i = 0; i <= (end - start) / 2; i++)
            {
                int tmp = nums[i + start];
                nums[i + start] = nums[end - i];
                nums[end - i] = tmp;
            }
        }
    }
}
