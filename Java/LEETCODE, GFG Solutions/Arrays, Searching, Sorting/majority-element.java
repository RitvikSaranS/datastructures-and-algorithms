//Majority element 1
class Solution {
    public int majorityElement(int[] nums) {
	    int count = 0;
	    int tmp = nums[0];
	    for(int i = 1; i < nums.length; i++){
	        if(count == 0 && i < nums.length) {
                tmp = nums[i];
            }
	        else if(nums[i] != tmp) count--;
	        else count++;
        }
        return tmp;
    }
}

//Majority element 2
