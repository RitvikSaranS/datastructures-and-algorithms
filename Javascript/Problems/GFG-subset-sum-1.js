//https://practice.geeksforgeeks.org/problems/subset-sums2234/1

let subsetSums = (arr) => {
       let result = [0];
       let helper = (ind, sum) => {
           for(let i = ind; i < arr.length; i++){
               result.push(sum + arr[i]);
               helper(i + 1, sum + arr[i]);
           }
       }
       helper(0, 0);
       console.log(result.sort((a,b) => a - b));
    }
subsetSums([5, 2]);