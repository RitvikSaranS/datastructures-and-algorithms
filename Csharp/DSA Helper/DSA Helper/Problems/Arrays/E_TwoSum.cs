using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    // https://leetcode.com/problems/two-sum
    class E_TwoSum
    {
        int[] nums;
        Hashtable ht;
        public E_TwoSum(int[] nums)
        {
            this.nums = nums;
            ht = new Hashtable();
        }
        public void TwoSum(int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                ht.Add(nums[i], "");
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if(ht.ContainsKey(target - nums[i]))
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }
            Console.WriteLine("No");
        }
    }
}
