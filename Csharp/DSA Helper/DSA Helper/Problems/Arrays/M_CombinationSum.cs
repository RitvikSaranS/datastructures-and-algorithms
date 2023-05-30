using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    // https://leetcode.com/problems/combination-sum/
    class M_CombinationSum
    {
        int[] nums;
        List<int> potential = new List<int>();
        public M_CombinationSum(int[] nums)
        {
            this.nums = nums;
        }
        public void CombinationSum(int sum)
        {
            int helper(int ind)
            {
                if (sum < 0) return 1;
                if (sum == 0)
                {
                    printList();
                    Console.WriteLine();
                }

                if (ind >= nums.Length) return 1;
                for (int i = ind; i < nums.Length; i++)
                {
                    sum -= nums[i];
                    potential.Add(nums[i]);
                    helper(i);
                    sum += nums[i];
                    potential.Remove(nums[i]);
                }
                return 1;
            }
            helper(0);
        }
        public void printList()
        {
            potential.ForEach(x => Console.Write(x + " "));
        }
    }
}
