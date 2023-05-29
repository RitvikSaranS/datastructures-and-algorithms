//https://leetcode.com/problems/combination-sum

/**
 * @param {number[]} candidates
 * @param {number} target
 * @return {number[][]}
 */
var combinationSum = function(candidates, target) {
    let res = []
    let tmp = []
    let helper = function(ind, diff){
        if(diff < 0) return;
        if(diff === 0){
            res.push([...tmp]);
            return;
        }
        for(let i = ind; i<candidates.length; i++){
            tmp.push(candidates[i])
            helper(i, diff - candidates[i]);
            tmp.pop();
        }
    }
    helper(0, target);
    return res;
};