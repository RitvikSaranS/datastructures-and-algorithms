https://leetcode.com/problems/find-minimum-in-rotated-sorted-array
class Solution {
    public int findMin(int[] nums) {
        int s = 0;
        int e = nums.length - 1;
        int m = -1;
        while(s < e){
            m = s + (e - s)/2;
            if(e > m && nums[m] > nums[m+1]) return nums[m + 1]; // for rotated, minimum will be next to maximum
            else if(s < m && nums[m] < nums[m - 1]) return nums[m]; // for rotated, minimum will be next to maximum
            else if(nums[m] < nums[e]) e = m - 1;
            else if(nums[s] < nums[m]) s = m;
        }
        return nums[0];  // array is not rotated return first element
    }
}