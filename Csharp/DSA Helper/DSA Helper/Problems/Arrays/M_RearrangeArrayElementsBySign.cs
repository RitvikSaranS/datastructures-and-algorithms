using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    class M_RearrangeArrayElementsBySign
    {
        int[] nums;
        public M_RearrangeArrayElementsBySign(int[] nums)
        {
            this.nums = nums;
        }
        public void Rearrange()
        {
            int positive = 0;
            int negative = 1;
            int[] arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    arr[positive] = nums[i];
                    positive += 2;
                }
                else
                {
                    arr[negative] = nums[i];
                    negative += 2;
                }
            }
            for (int k = 0; k < nums.Length; k++)
            {
                Console.Write(nums[k] + " ");
            }
        }
    }
}
