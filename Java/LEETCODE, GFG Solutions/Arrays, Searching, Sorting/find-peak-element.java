//https://leetcode.com/problems/peak-index-in-a-mountain-array/
https://leetcode.com/problems/find-peak-element/
class Solution {
    public int findPeakElement(int[] nums) {
        int s = 0;
        int e = nums.length - 1;
        int m = -1;
        while(s < e){
            m = s + (e - s)/2;
            if(nums[m] < nums[m+1]) s = m+1;
            else e = m;
        }
        return s;
    }
}