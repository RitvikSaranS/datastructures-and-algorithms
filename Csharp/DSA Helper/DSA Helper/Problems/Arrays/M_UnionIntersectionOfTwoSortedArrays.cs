using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Helper.Problems.Arrays
{
    // There are approaches using Maps and Sets. This is Two Pointer Method
    class M_UnionIntersectionOfTwoSortedArrays
    {
        int[] nums1;
        int[] nums2;
        public M_UnionIntersectionOfTwoSortedArrays(int[] nums1, int[] nums2)
        {
            this.nums1 = nums1;
            this.nums2 = nums2;
        }
        public void Union()
        {
            List<int> unionList = new List<int>();
            int i = 0;
            int j = 0;
            while(i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j]) i++;
                else if(nums1[i] < nums2[j])
                {
                    if(unionList.Count == 0)
                        unionList.Add(nums1[i]);
                    else if (unionList.Count != 0 && unionList[unionList.Count - 1] != nums1[i])
                        unionList.Add(nums1[i]);
                    i++;
                }
                else
                {
                    if (unionList.Count == 0)
                        unionList.Add(nums1[j]);
                    else if (unionList.Count != 0 && unionList[unionList.Count - 1] != nums2[j])
                        unionList.Add(nums2[j]);
                    j++;
                }
            }
            while(i < nums1.Length)
            {
                if(unionList[unionList.Count - 1] != nums1[i])
                {
                    unionList.Add(nums1[i++]);
                }
            }
            while (j < nums2.Length)
            {
                if (unionList[unionList.Count - 1] != nums2[j])
                {
                    unionList.Add(nums2[j++]);
                }
            }
            for(int k = 0; k < unionList.Count; k++)
            {
                Console.Write(unionList[k] + " ");
            }
        }
        public void Intersection()
        {
            List<int> intersectionList = new List<int>();
            int i = 0;
            int j = 0;
            while(i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    intersectionList.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if (nums1[i] < nums2[j]) i++;
                else j++;
            }
            for (int k = 0; k < intersectionList.Count; k++)
            {
                Console.Write(intersectionList[k] + " ");
            }
        }
    }
}
