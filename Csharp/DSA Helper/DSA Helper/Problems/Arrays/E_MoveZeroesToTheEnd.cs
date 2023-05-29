using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    class E_MoveZeroesToTheEnd
    {
        // Intuition : When checking for non zero we are also checking for zero indirectly.
        // https://leetcode.com/problems/move-zeroes
        int[] nums;
        public E_MoveZeroesToTheEnd(int[] nums)
        {
            this.nums = nums;
        }
        public void MoveZeroes()
        {
            if (nums.Length <= 1) return;
            int i = 0;
            for(; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    break;
                }
            }
            int zeroIndex = i;
            int potentialNonZero = i + 1;
            while(zeroIndex < nums.Length && potentialNonZero < nums.Length)
            {
                if(nums[potentialNonZero] != 0)
                {
                    swap(nums, potentialNonZero, zeroIndex);
                    zeroIndex++;
                }
                potentialNonZero++;
            }
            for (int k = 0; k < nums.Length; k++)
            {
                Console.Write(nums[k] + " ");
            }
        }
        public void swap(int[] nums, int a, int b)
        {
            if (a >= nums.Length || b >= nums.Length)
            {
                return;
            }
            int tmp = nums[a];
            nums[a] = nums[b];
            nums[b] = tmp;
        }
    }
}
