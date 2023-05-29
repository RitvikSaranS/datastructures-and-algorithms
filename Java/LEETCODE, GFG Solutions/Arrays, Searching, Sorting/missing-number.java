class Solution {
    public int missingNumber(int[] nums) {
        int i = 0;
        // Using cyclic sort to sort the numbers
        while(i < nums.length){
            if(nums[i] != nums.length && nums[i] != i){
                int correct = nums[i];
                int temp = nums[i];
                nums[i] = nums[correct];
                nums[correct] = temp;
            }else{
                i++;
            }
        }
        // When sorted the every element will be equal to its index.
        // Only missing element will be another number in it.
        for(int j = 0; j < nums.length; j++){
            int correct = nums[j];
            if(nums[j] != j) return j;
        }return nums.length;
    }
}