using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    class M_LongestConsecutiveSequence
    {
        int[] nums;
        Hashtable ht;
        public M_LongestConsecutiveSequence(int[] nums)
        {
            this.nums = nums;
            ht = new Hashtable();
        }
        public void LongestConsecutiveSequence()
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (!ht.ContainsKey(nums[i])) ht.Add(nums[i], nums[i]);
            }
            int max = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(!ht.Contains(nums[i] - 1))
                {
                    int element = nums[i];
                    int count = 0;
                    while (ht.Contains(element))
                    {
                        count++;
                        element++;
                    }
                    max = Math.Max(max, count);
                }
            }
            Console.WriteLine(max);
        }
    }
}
