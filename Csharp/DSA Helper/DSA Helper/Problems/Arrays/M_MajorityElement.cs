using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    // Moore's Voting Algorithm
    // https://leetcode.com/problems/majority-element
    class M_MajorityElement
    {
        int[] nums;
        public M_MajorityElement(int[] nums)
        {
            this.nums = nums;
        }
        public void FindMajority()
        {
            int count = 0;
            int num = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    num = nums[i];
                    count++;
                }
                else if (count != 0)
                {
                    if (nums[i] == num)
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine(num);
        }
    }
}
