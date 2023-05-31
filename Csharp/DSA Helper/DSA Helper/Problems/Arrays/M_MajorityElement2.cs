using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    // Moore's Voting Algorithm
    // https://leetcode.com/problems/majority-element-ii
    class M_MajorityElement2
    {
        int[] nums;
        public M_MajorityElement2(int[] nums)
        {
            this.nums = nums;
        }
        public void FindMajority()
        {
            int targetCount = (int)nums.Length / 3;
            int element1 = 0;
            int element2 = 0;
            int count1 = 0;
            int count2 = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == element1) count1++;
                else if (nums[i] == element2) count2++;
                else if(count1 == 0 && element1 != nums[i])
                {
                    count1 = 1;
                    element1 = nums[i];
                }
                else if(count2 == 0 && element2 != nums[i])
                {
                    count2 = 1;
                    element2 = nums[i];
                }
                else
                {
                    count1--;
                    count2--;
                }
            }
            count1 = 0; count2 = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (element1 == nums[i]) count1++;
                else if (element2 == nums[i]) count2++;
            }
            if (count1 > targetCount) Console.WriteLine(element1);
            if (count2 > targetCount) Console.WriteLine(element2);
        }
    }
}
