using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA_Helper.Problems.Dynamic_Programming
{
    // https://practice.geeksforgeeks.org/problems/minimal-cost/1
    class M_GeekJump2
    {
        int[] levels;
        public M_GeekJump2(int[] levels)
        {
            this.levels = levels;
        }
        public void MinimumCost_Recursive(int k)
        {
            int helper(int n)
            {
                if (n == 0) return 0;
                int min = Int32.MaxValue;
                for(int i = 1; i <= k; i++)
                {
                    if(n - i >= 0)
                    {
                        min = Math.Min(min, helper(n - i) + Math.Abs(levels[n] - levels[n - i]));
                    }
                }
                return min;
            }
            int result = helper(levels.Length - 1);
            Console.WriteLine(result);
        }
        public void MinimumCost_Best(int k)
        {
            int[] dp = new int[levels.Length];
            for (int i = 1; i < levels.Length; i++)
            {
                int min = Int32.MaxValue;
                for(int j = 1; j <= k; j++)
                {
                    if(i - j >= 0) min = Math.Min(min, dp[i - j] + Math.Abs(levels[i] - levels[i - j]));
                }
                dp[i] = min;
            }
            Console.WriteLine(dp[dp.Length - 1]);
        }
    }
}
