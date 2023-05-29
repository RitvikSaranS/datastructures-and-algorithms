using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Arsenal
{
    class Sorting
    {
        int[] nums;
        public Sorting(int[] nums)
        {
            this.nums = nums;
        }

        // Merge Sort
        public void MergeSort()
        {
            Helper(0, nums.Length - 1);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
        public void Helper(int start, int end)
        {
            if (nums.Length == 0) return;
            if (start == end) return;
            int mid = start + (end - start) / 2;
            Helper(start, mid);
            Helper(mid + 1, end);
            Merger(start, mid + 1, end);
        }
        public void Merger(int start, int mid, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (nums[start] <= nums[mid])
                {
                    start++;
                }
                else
                {
                    int tmp = nums[start];
                    nums[start] = nums[mid];
                    nums[mid] = tmp;
                    int j = mid;
                    while (j < end && nums[j] > nums[j + 1])
                    {
                        int tmp2 = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = tmp2;
                        j++;
                    }
                }
            }
        }

        // Quick Sort
        public void QuickSort()
        {
            helper(0, nums.Length - 1);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
        public void helper(int start, int end)
        {
            if (nums.Length == 0) return;
            if (start >= end) return;
            int start2 = start;
            int end2 = end;
            int mid = start + (end - start) / 2;
            int pivotEle = nums[mid];
            while (start < end)
            {
                while (start < end && nums[start] < nums[mid])
                {
                    start++;
                }
                while (end > start && nums[end] > nums[mid])
                {
                    end--;
                }
                if (start < end)
                {
                    int tmp = nums[start];
                    nums[start] = nums[end];
                    nums[end] = tmp;
                }
            }
            start = (pivotEle == nums[start]) ? start : end;
            helper(start2, start - 1);
            helper(start + 1, end2);
        }
    }
}
