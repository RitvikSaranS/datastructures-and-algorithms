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
                if (n == 0) return 0;
                int left = Math.Abs(levels[n] - levels[n - 1]) + helper(n - 1);
                int right = (n > 1) ? Math.Abs(levels[n] - levels[n - 2]) + helper(n - 2) : Int32.MaxValue;
                return Math.Min(left, right);
            }
            int result = helper(levels.Length - 1);
            Console.WriteLine(result);
        }
        public void MinimumEnergy_Best()
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i < levels.Length; i++)
            {
                int left = sum1 + Math.Abs(levels[i] - levels[i - 1]);
                int right = i > 1 ? sum2 + Math.Abs(levels[i] - levels[i - 2]) : Int32.MaxValue;
                sum2 = sum1;
                sum1 = Math.Min(left, right);
            }
            Console.WriteLine(sum1);
        }
    }
}
