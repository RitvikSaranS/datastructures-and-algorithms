using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Arsenal
{
    class Searching
    {
        int[] nums;
        public Searching(int[] nums)
        {
            this.nums = nums;
        }
        // Type can be normal(default), nextbig or nextsmall
        public int BinarySearch(int target, int start = 0, int end = -1, string type = "normal")
        {
            if (nums.Length == 0) return -1;
            bool isDesc = nums[0] > nums[nums.Length - 1];
            end = (end == -1) ? nums.Length - 1 : end;
            int mid = -1;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (nums[mid] == target) return mid;
                if (nums[mid] > target)
                {
                    if (isDesc)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
                else if (isDesc)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            if (type == "nextbig")
            {
                if (start < nums.Length)
                {
                    return start;
                }
                else
                {
                    return -1;
                }
            }
            if (type == "nextsmall")
            {
                if (end >= 0)
                {
                    return end;
                }
                else
                {
                    return -1;
                }
            }
            return -1;
        }
        public int PivotFinder()
        {
            if (nums.Length == 0) return -1;
            int start = 0;
            int end = nums.Length - 1;
            int mid = -1;
            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (end > mid && nums[mid] > nums[mid + 1]) return mid + 1;
                if (start < mid && nums[mid] < nums[mid - 1]) return mid;
                if (nums[mid] >= nums[start] && nums[mid] > nums[end])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                    continue;
                }
                if (nums[start] == nums[mid] && nums[mid] == nums[end])
                {
                    start++;
                    end--;
                }
            }
            return 0;
        }
        public int LinearSearch(int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;
            }
            return -1;
        }
    }
}
