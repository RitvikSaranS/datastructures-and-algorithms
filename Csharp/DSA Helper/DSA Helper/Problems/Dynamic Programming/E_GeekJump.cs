using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Dynamic_Programming
{
    // https://practice.geeksforgeeks.org/problems/geek-jump/1
    class E_GeekJump
    {
        int[] levels;
        public E_GeekJump(int[] levels)
        {
            this.levels = levels;
        }
        public void MinimumEnergy_Recursive()
        {
            int helper(int n)
            {
                if (n < 0) return levels[0];
                return Math.Min(Math.Abs(levels[n] - helper(n - 1)), Math.Abs(levels[n] - helper(n - 2)));
            }
        }
        public void MinimumEnergy_Best()
        {

        }
    }
}
