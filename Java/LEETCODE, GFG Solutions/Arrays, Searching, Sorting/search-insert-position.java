class Solution {
    public int searchInsert(int[] nums, int target) {
        int s = 0;
        int e = nums.length - 1;
        int m = -1;
        while(s <= e){
            m = s + (e - s)/2;
            if(nums[m] > target) e = m-1;
            else if(nums[m] < target) s = m+1;
            else return mid;
        }
        return e;
    }
}