//https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
class Solution {
    public int[] searchRange(int[] nums, int target) {
        if(binarysearch(nums, target)){ 
            int rightindex = helpersearch(nums, target, true);
            int leftindex = helpersearch(nums, target, false);
            return new int[]{leftindex, rightindex};
        }
        return new int[]{-1, -1};
    }
    public int helpersearch(int [] nums, int target, boolean check){
        if(nums.length == 1) return 0;
        int s = 0;
        int e = nums.length - 1;
        int m = -1;
        while(s <= e){
            m = s + (e - s)/2;
            if(nums[m] > target) e = m - 1;
            else if(nums[m] < target) s = m + 1;
            else if(check) s = m + 1;
            else e = m - 1;
        }
        if(check) return e;
        else return s;
    }
    public boolean binarysearch(int [] nums, int target){
        int s = 0;
        int e = nums.length - 1;
        int m = -1;
        while(s <= e){
            m = s + (e - s)/2;
            if(nums[m] > target) e = m - 1;
            else if(nums[m] < target) s = m + 1;
            else return true;
        }
        return false;
    }
}