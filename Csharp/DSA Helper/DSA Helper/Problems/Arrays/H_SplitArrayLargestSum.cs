using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    class H_SplitArrayLargestSum
    {
        int[] arr;
        int k;
        public H_SplitArrayLargestSum(int[] arr, int k)
        {
            this.arr = arr;
            this.k = k;
        }
        public void SplitArrayLargestSum()
        {
            // arr = { 7,2,5,10,8 } k = 2
            int lowerLimit = arr[0];
            int upperLimit = 0;
            int res = -1;
            int result = -1;
            foreach(int item in arr)
            {
                lowerLimit = Math.Max(lowerLimit, item);
                upperLimit += item;
            }
            int arraySum = upperLimit;
            while (lowerLimit <= upperLimit)
            {
                int mid = lowerLimit + (upperLimit - lowerLimit) / 2;
                res = checkIfFeasible(mid, k, arraySum);
                if (res != -1)
                {
                    upperLimit = mid - 1;
                    result = res;
                }
                else
                {
                    lowerLimit = mid + 1;
                }
            }
            Console.WriteLine(result);
        }
        public int checkIfFeasible(int potentialSum, int k, int arraySum)
        {
            int i = 0, sum = 0;
            while(i < arr.Length)
            {
                int maxSubarraySum = Math.Max(sum, arraySum - sum);
                if (maxSubarraySum <= potentialSum && arr.Length - i >= k)
                {
                    return maxSubarraySum;
                }
                sum += arr[i++];
            }
            return -1;
        }
    }
}
