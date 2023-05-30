using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Dynamic_Programming
{
    // https://practice.geeksforgeeks.org/problems/max-sum-without-adjacents2430/1
    // https://practice.geeksforgeeks.org/problems/stickler-theif-1587115621/1
    class E_MaximumSumOfNonAdjascentElements
    {
        int[] arr;
        public E_MaximumSumOfNonAdjascentElements(int[] arr)
        {
            this.arr = arr;
        }
        public void MaximumSum_Recursive()
        {
            if (arr.Length == 2)
            {
                if (arr[0] > arr[1]) Console.WriteLine(arr[0]);
                else Console.WriteLine(arr[1]);
            }
            int helper(int n)
            {
                if (n <= 1) return arr[n];
                int max = arr[n];
                for(int i = n - 2; i >= 0; i--)
                {
                    max = Math.Max(max, Math.Max(arr[n] + helper(i), helper(i + 1)));
                }
                return max;
            }
            int result = helper(arr.Length - 1);
            Console.WriteLine(result);
        }
        public void MaximumSum_Best()
        {
            if (arr.Length == 2)
            {
                if (arr[0] > arr[1]) Console.WriteLine(arr[0]);
                else Console.WriteLine(arr[1]);
            }
            int[] dp = new int[arr.Length];
            for(int i = 0; i < dp.Length; i++)
            {
                int max = arr[i];
                for(int j = i - 2; j >= 0; j--)
                {
                    max = Math.Max(max, Math.Max(arr[i] + dp[j], dp[j + 1]));
                }
                dp[i] = max;
            }
            Console.WriteLine(dp[dp.Length - 1]);
        }
    }
}
