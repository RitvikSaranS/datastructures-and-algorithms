//https://leetcode.com/problems/find-target-indices-after-sorting-array/
class Solution {
    public List<Integer> targetIndices(int[] nums, int target) {
        Arrays.sort(nums);
        List<Integer> list = new ArrayList<>();
        if(binarysearch(nums, target)){ 
            int rightindex = helpersearch(nums, target, true);
            int leftindex = helpersearch(nums, target, false);
            for(int i = leftindex; i <= rightindex; i++){
                list.add(i);
            }
            return list;
        }
        return list;
    }
    // finds the left and right indices of the target
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
    // checks if target is present
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