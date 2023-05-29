using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    class M_SortArrayOfZeroOneTwo
    {
        int[] nums;
        public M_SortArrayOfZeroOneTwo(int[] nums)
        {
            this.nums = nums;
        }
        public void Sort()
        {
            int i = 0;
            int j = nums.Length - 1;
            int k = 0;
            while (i < nums.Length && j >= 0 && k <= j)
            {
                if(nums[k] == 2)
                {
                    swap(nums, k, j);
                    j--;
                }else if(nums[k] == 0)
                {
                    swap(nums, k, i);
                    i++;
                    k++;
                }
                else
                {
                    k++;
                }
            }
            for (int l = 0; l < nums.Length; l++)
            {
                Console.Write(nums[l] + " ");
            }
        }
        public void swap(int[]nums, int a, int b)
        {
            if (a > nums.Length || b < 0) return;
            int tmp = nums[a];
            nums[a] = nums[b];
            nums[b] = tmp;
        }
    }
}
