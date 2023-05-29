https://leetcode.com/problems/search-in-rotated-sorted-array-ii
class Solution {
    public boolean search(int[] nums, int target) {
        int s = 0;
        int e = nums.length - 1;
        int m = -1;
        while(s <= e){
            m = s + (e - s)/2;
            if(nums[m] == target) return true;    // answer found at mid
            else if(s < e && nums[s] == nums[m] && nums[m] == nums[e]){ // nums[s] == nums[m] == nums[e]
                s++;
                e--;
            }
            else if(nums[s] <= nums[m]){
                if(target < nums[m] && target >= nums[s]) e = m - 1; // answer to left sorted part
                else s = m + 1;
            }else if(nums[e] >= nums[m]){
                if(target > nums[m] && target <= nums[e]) s = m + 1; // answer to right sorted part
                else e = m - 1;
            }
        }
        return false;   //if not found return false
    }
}