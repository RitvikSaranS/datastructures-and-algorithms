//https://leetcode.com/problems/subsets

/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var subsets = function(nums) {
    let tmp = [];
    let result = [[]];
    let helper = (ind) => {
        for(let i = ind; i < nums.length; i++){
            tmp.push(nums[i]);
            result.push([...tmp]);
            helper(i + 1);
            tmp.pop();
        }
    }
    helper(0);
    return  result;
};