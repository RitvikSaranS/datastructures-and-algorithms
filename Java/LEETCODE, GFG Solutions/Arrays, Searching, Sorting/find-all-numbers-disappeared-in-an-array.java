class Solution {
    public List<Integer> findDisappearedNumbers(int[] nums) {
        int i = 0;
        List<Integer> list = new ArrayList<>();
        // Cyclic Sort
        while(i < nums.length){
            int correct = nums[i] - 1;
            if(nums[i] != nums[correct]){
                int temp = nums[i];
                nums[i] = nums[correct];
                nums[correct] = temp;
            }else {
                i++;
            }
        }
        for(int j = 0; j < nums.length; j++){
            if(nums[j] != (j+1)) list.add(j+1);
        }
        return list;
    }
}

/*
* Why cyclic sort is used?
     The array has elements from [0, n] or [1, n], for problems of this type
    we can use cyclic sort.
  How did we reach to the solution? 
     After the cyclic sort, in place of the indices of missing numbers, other 
    numbers would be residing.
*/