using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Dynamic_Programming
{
    // https://leetcode.com/problems/climbing-stairs
    class E_ClimbingStairs
    {
        int stairs;
        public E_ClimbingStairs(int stairs)
        {
            this.stairs = stairs;
        }
        public void CountJumps_Recursive()
        {
            int helper(int stair)
            {
                if (stair < 0) return 0;
                if (stair == 0) return 1;
                return helper(stair - 1) + helper(stair - 2);
            }
            int result = helper(stairs);
            Console.WriteLine(result);
        }
        public void CountJumps_Iterative()
        {
            var dp = new int[] { 1, 1 };
            for(int i = 1; i < stairs; i++)
            {
                (dp[0], dp[1]) = (dp[1], dp[0]);
                dp[1] += dp[0];
            }
            Console.WriteLine(dp[1]);
        }
        public void CountJumps_Best()
        {
            int i = 1, j = 1;
            for (int k = 1; k < stairs; k++)
            {
                (i, j) = (j, i);
                j += i;
            }
            Console.WriteLine(j);
        }
    }
}
